program projCapitulo10;

uses
  Vcl.Forms,
  uSerialMonitor in 'uSerialMonitor.pas' {frmSerialMonitor};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TfrmSerialMonitor, frmSerialMonitor);
  Application.Run;
end.
