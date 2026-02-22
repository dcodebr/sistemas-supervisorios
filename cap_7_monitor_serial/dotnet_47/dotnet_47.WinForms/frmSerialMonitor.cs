using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_47.WinForms
{
    public partial class frmSerialMonitor : Form
    {
        public frmSerialMonitor()
        {
            InitializeComponent();

            atualizaPortasCOM();
            atualizaParidades();
            atualizaBitsParada();
            cboVelocidade.SelectedIndex = 5; //valor: 9600
            cboBitDados.SelectedIndex = 3;   //valor: 8
        }

        private void atualizaPortasCOM()
        {
            cboPorta.Items.Clear();

            var serialPorts = SerialPort.GetPortNames()
                                        .ToList();

            if (serialPorts.Count > 0)
            {
                serialPorts.ForEach(serialPort => cboPorta.Items.Add(serialPort));
                cboPorta.SelectedIndex = 0;
            }
        }

        private void atualizaParidades()
        {
            //Baseado no Enum Parity
            cboParidade.Items.Clear();

            var parities = Enum.GetNames(typeof(Parity))
                               .ToList();

            parities.ForEach(parity => cboParidade.Items.Add(parity));
            cboParidade.SelectedIndex = 0;
        }

        private void atualizaBitsParada()
        {
            //Baseado no Enum Parity
            cboBitParada.Items.Clear();

            var stopBits = Enum.GetNames(typeof(StopBits))
                               .ToList();

            stopBits.ForEach(stopBit => cboBitParada.Items.Add(stopBit));
            cboBitParada.SelectedIndex = 1;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirPorta_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.Close();
            }

            serial.PortName = cboPorta.Text;
            serial.BaudRate = Convert.ToInt32(cboVelocidade.Text);
            serial.Parity = (Parity)cboParidade.SelectedIndex;
            serial.DataBits = Convert.ToInt32(cboBitDados.Text);
            serial.StopBits = (StopBits)cboBitParada.SelectedIndex;

            try
            {
                serial.Open();
                btnAbrirPorta.Enabled = false;
                btnFecharPorta.Enabled = true;
                btnSair.Enabled = false;
                btnEnviar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Test",
                                "ATENÇÃO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                btnFecharPorta.Enabled = false;
                btnAbrirPorta.Enabled = true;
                btnSair.Enabled = false;
                btnEnviar.Enabled = false;
            }
        }

        private void btnFecharPorta_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.Close();
                btnAbrirPorta.Enabled = true;
                btnFecharPorta.Enabled = false;
                btnSair.Enabled = true;
                btnEnviar.Enabled = false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!serial.IsOpen) {
                return;
            }

            var crText = ckbCR.Checked ? "\r" : String.Empty;
            var transmissao = txtTransmissao.Text;
            var conteudo = $"{transmissao}{crText}";

            serial.Write(conteudo);
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var content = serial.ReadExisting();

            this.Invoke((Action)(() =>
            {
                txtRecepcao.Text = content;
            }));
        }
    }
}

