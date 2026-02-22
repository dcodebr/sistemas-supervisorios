unit uSerialMonitor;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants,
  System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, CPort, System.TypInfo,
  System.Math;

type
  TfrmSerialMonitor = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    GroupBox1: TGroupBox;
    btnAbrirPorta: TButton;
    btnFecharPorta: TButton;
    btnSair: TButton;
    GroupBox2: TGroupBox;
    GroupBox3: TGroupBox;
    cboPorta: TComboBox;
    cboVelocidade: TComboBox;
    cboParidade: TComboBox;
    cboBitDados: TComboBox;
    cboBitParada: TComboBox;
    Label6: TLabel;
    txtTransmissao: TEdit;
    Label7: TLabel;
    memRecepcao: TMemo;
    btnEnviar: TButton;
    serial: TComPort;
    ckbCR: TCheckBox;

    procedure atualizaPortaCom();
    procedure atualizaVelocidades();
    procedure atualizaParidades();
    procedure atualizaBitsDados();
    procedure atualizaBitsParada();
    procedure FormActivate(Sender: TObject);
    procedure btnSairClick(Sender: TObject);
    procedure btnAbrirPortaClick(Sender: TObject);
    procedure btnFecharPortaClick(Sender: TObject);
    procedure btnEnviarClick(Sender: TObject);
    procedure serialRxChar(Sender: TObject; Count: Integer);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frmSerialMonitor: TfrmSerialMonitor;

implementation

{$R *.dfm}
{ TfrmSerialMonitor }

procedure TfrmSerialMonitor.atualizaBitsDados;
var
  i: Integer;
begin
  cboBitDados.Items.Clear;

  for i := Ord(Low(TDataBits)) to Ord(High(TDataBits)) do
    cboBitDados.Items.Add(GetEnumName(TypeInfo(TDataBits), i));

  cboBitDados.ItemIndex := 3;
end;

procedure TfrmSerialMonitor.atualizaBitsParada;
var
  i: Integer;
begin
  cboBitParada.Items.Clear;

  for i := Ord(Low(TStopBits)) to Ord(High(TStopBits)) do
    cboBitParada.Items.Add(GetEnumName(TypeInfo(TStopBits), i));

  cboBitParada.ItemIndex := 0;
end;

procedure TfrmSerialMonitor.atualizaParidades;
var
  i: Integer;
begin
  cboParidade.Items.Clear;

  for i := Ord(Low(TParityBits)) to Ord(High(TParityBits)) do
    cboParidade.Items.Add(GetEnumName(TypeInfo(TParityBits), i));

  cboParidade.ItemIndex := 0;
end;

procedure TfrmSerialMonitor.atualizaPortaCom;
var
  serialPorts: TStringList;
begin
  cboPorta.Items.Clear;

  serialPorts := TStringList.Create;
  EnumComPorts(serialPorts); // Usando o ComPort Library

  cboPorta.Items.Assign(serialPorts);

  IF cboPorta.Items.Count > 0 THEN
    cboPorta.ItemIndex := 0;
end;

procedure TfrmSerialMonitor.atualizaVelocidades;
var
  i: Integer;
begin
  cboVelocidade.Items.Clear;

  for i := Ord(Low(TBaudRate)) to Ord(High(TBaudRate)) do
    cboVelocidade.Items.Add(GetEnumName(TypeInfo(TBaudRate), i));

  cboVelocidade.ItemIndex := 7; // 9600
end;

procedure TfrmSerialMonitor.btnAbrirPortaClick(Sender: TObject);
begin
  IF serial.Connected THEN
    serial.Close;

  serial.Port := cboPorta.Text;
  serial.BaudRate := TBaudRate(cboVelocidade.ItemIndex);
  serial.Parity.Bits := TParityBits(cboParidade.ItemIndex);
  serial.DataBits := TDataBits(cboBitDados.ItemIndex);
  serial.StopBits := TStopBits(cboBitParada.ItemIndex);

  serial.Open;
  btnFecharPorta.Enabled := True;
  btnEnviar.Enabled := True;
  btnAbrirPorta.Enabled := False;
  btnSair.Enabled := False;
end;

procedure TfrmSerialMonitor.btnEnviarClick(Sender: TObject);
var
  mensagem, crtext: String;
begin

  IF ckbCR.Checked THEN
    crtext := #13#10;

  mensagem := txtTransmissao.Text + crtext;
  serial.WriteStr(mensagem);
end;

procedure TfrmSerialMonitor.btnFecharPortaClick(Sender: TObject);
begin
  IF serial.Connected THEN
    serial.Close;

  btnAbrirPorta.Enabled := True;
  btnSair.Enabled := True;
  btnFecharPorta.Enabled := False;
  btnEnviar.Enabled := False;
end;

procedure TfrmSerialMonitor.btnSairClick(Sender: TObject);
begin
  Application.Terminate;
end;

procedure TfrmSerialMonitor.FormActivate(Sender: TObject);
begin
  atualizaPortaCom();
  atualizaVelocidades();
  atualizaParidades();
  atualizaBitsDados();
  atualizaBitsParada();
end;

procedure TfrmSerialMonitor.serialRxChar(Sender: TObject; Count: Integer);
var
  mensagem: String;
begin
  serial.ReadStr(mensagem, Count);
  memRecepcao.Lines.Add(mensagem);
end;

end.
