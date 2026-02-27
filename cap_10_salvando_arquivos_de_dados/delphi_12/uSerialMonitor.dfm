object frmSerialMonitor: TfrmSerialMonitor
  Left = 0
  Top = 0
  BorderIcons = [biSystemMenu]
  BorderStyle = bsSingle
  Caption = 'Serial Monitor'
  ClientHeight = 311
  ClientWidth = 727
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -12
  Font.Name = 'Segoe UI'
  Font.Style = []
  Menu = MainMenu1
  Position = poScreenCenter
  OnActivate = FormActivate
  TextHeight = 15
  object Label1: TLabel
    Left = 8
    Top = 19
    Width = 31
    Height = 15
    Caption = 'Porta:'
  end
  object Label2: TLabel
    Left = 183
    Top = 19
    Width = 60
    Height = 15
    Caption = 'Velocidade:'
  end
  object Label3: TLabel
    Left = 358
    Top = 19
    Width = 49
    Height = 15
    Caption = 'Paridade:'
  end
  object Label4: TLabel
    Left = 8
    Top = 75
    Width = 69
    Height = 15
    Caption = 'Bit de Dados:'
  end
  object Label5: TLabel
    Left = 183
    Top = 75
    Width = 72
    Height = 15
    Caption = 'Bit de Parada:'
  end
  object GroupBox1: TGroupBox
    Left = 533
    Top = 8
    Width = 185
    Height = 121
    Caption = 'A'#231#245'es'
    TabOrder = 0
    object btnAbrirPorta: TButton
      Left = 11
      Top = 24
      Width = 166
      Height = 25
      Caption = 'Abrir Porta'
      TabOrder = 0
      OnClick = btnAbrirPortaClick
    end
    object btnFecharPorta: TButton
      Left = 11
      Top = 55
      Width = 166
      Height = 25
      Caption = 'Fechar Porta'
      Enabled = False
      TabOrder = 1
      OnClick = btnFecharPortaClick
    end
    object btnSair: TButton
      Left = 11
      Top = 86
      Width = 166
      Height = 25
      Caption = 'Sair'
      TabOrder = 2
      OnClick = btnSairClick
    end
  end
  object cboPorta: TComboBox
    Left = 8
    Top = 40
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 1
  end
  object cboVelocidade: TComboBox
    Left = 183
    Top = 40
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 2
  end
  object cboParidade: TComboBox
    Left = 358
    Top = 40
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 3
  end
  object cboBitDados: TComboBox
    Left = 8
    Top = 96
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 4
  end
  object cboBitParada: TComboBox
    Left = 183
    Top = 95
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 5
  end
  object GroupBox2: TGroupBox
    Left = 8
    Top = 144
    Width = 344
    Height = 129
    Caption = 'Controle'
    TabOrder = 6
    object lblControle: TLabel
      Left = 61
      Top = 32
      Width = 140
      Height = 75
      Caption = '0000'
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -64
      Font.Name = 'Consolas'
      Font.Style = []
      ParentFont = False
    end
    object btnIniciar: TButton
      Left = 232
      Top = 40
      Width = 75
      Height = 25
      Caption = 'Iniciar'
      TabOrder = 0
      OnClick = btnIniciarClick
    end
    object btnFinalizar: TButton
      Left = 232
      Top = 71
      Width = 75
      Height = 25
      Caption = 'Finalizar'
      TabOrder = 1
      OnClick = btnFinalizarClick
    end
  end
  object StatusBar1: TStatusBar
    Left = 0
    Top = 292
    Width = 727
    Height = 19
    Panels = <
      item
        Width = 200
      end>
    ExplicitLeft = 216
    ExplicitTop = 280
    ExplicitWidth = 0
  end
  object serial: TComPort
    BaudRate = br9600
    Port = 'COM1'
    Parity.Bits = prNone
    StopBits = sbOneStopBit
    DataBits = dbEight
    Events = [evRxChar, evTxEmpty, evRxFlag, evRing, evBreak, evCTS, evDSR, evError, evRLSD, evRx80Full]
    FlowControl.OutCTSFlow = False
    FlowControl.OutDSRFlow = False
    FlowControl.ControlDTR = dtrDisable
    FlowControl.ControlRTS = rtsDisable
    FlowControl.XonXoffOut = False
    FlowControl.XonXoffIn = False
    StoredProps = [spBasic]
    TriggersOnRxChar = True
    OnRxChar = serialRxChar
    Left = 360
    Top = 70
  end
  object svLog: TSaveDialog
    FileName = 'log.txt'
    Filter = 'txt files (*.txt)|*.txt|All files (*.*)|*.*'
    Title = 'Salvar Aquivo de Log'
    Left = 400
    Top = 72
  end
  object MainMenu1: TMainMenu
    Left = 440
    Top = 72
    object Arquivo1: TMenuItem
      Caption = 'Arquivo'
      object btnSalvar: TMenuItem
        Caption = '&Salvar'
        OnClick = btnSalvarClick
      end
      object Sair1: TMenuItem
        Caption = 'Sair'
        OnClick = Sair1Click
      end
    end
  end
end
