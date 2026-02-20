object frmSerialMonitor: TfrmSerialMonitor
  Left = 0
  Top = 0
  BorderIcons = [biSystemMenu]
  BorderStyle = bsSingle
  Caption = 'Serial Monitor'
  ClientHeight = 390
  ClientWidth = 727
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -12
  Font.Name = 'Segoe UI'
  Font.Style = []
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
  object GroupBox2: TGroupBox
    Left = 8
    Top = 135
    Width = 710
    Height = 121
    Caption = 'Transmiss'#227'o'
    TabOrder = 1
    object Label6: TLabel
      Left = 9
      Top = 27
      Width = 56
      Height = 15
      Caption = 'Conte'#250'do:'
    end
    object txtTransmissao: TEdit
      Left = 9
      Top = 48
      Width = 693
      Height = 23
      TabOrder = 0
    end
    object btnEnviar: TButton
      Left = 536
      Top = 81
      Width = 166
      Height = 25
      Caption = 'Enviar'
      Enabled = False
      TabOrder = 1
      OnClick = btnEnviarClick
    end
  end
  object GroupBox3: TGroupBox
    Left = 8
    Top = 262
    Width = 710
    Height = 121
    Caption = 'Recep'#231#227'o'
    TabOrder = 2
    object Label7: TLabel
      Left = 9
      Top = 26
      Width = 56
      Height = 15
      Caption = 'Conte'#250'do:'
    end
    object memRecepcao: TMemo
      Left = 9
      Top = 47
      Width = 693
      Height = 58
      ReadOnly = True
      TabOrder = 0
    end
  end
  object cboPorta: TComboBox
    Left = 8
    Top = 40
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 3
  end
  object cboVelocidade: TComboBox
    Left = 183
    Top = 40
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 4
  end
  object cboParidade: TComboBox
    Left = 358
    Top = 40
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 5
  end
  object cboBitDados: TComboBox
    Left = 8
    Top = 96
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 6
  end
  object cboBitParada: TComboBox
    Left = 183
    Top = 95
    Width = 169
    Height = 23
    Style = csDropDownList
    TabOrder = 7
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
    Left = 368
    Top = 78
  end
end
