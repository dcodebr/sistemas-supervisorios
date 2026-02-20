namespace dotnet_47.WinForms
{
    partial class frmSerialMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPorta = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboVelocidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboParidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBitDados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBitParada = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.btnAbrirPorta = new System.Windows.Forms.Button();
            this.btnFecharPorta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransmissao = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRecepcao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porta:";
            // 
            // cboPorta
            // 
            this.cboPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPorta.FormattingEnabled = true;
            this.cboPorta.Location = new System.Drawing.Point(12, 29);
            this.cboPorta.Name = "cboPorta";
            this.cboPorta.Size = new System.Drawing.Size(163, 21);
            this.cboPorta.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnFecharPorta);
            this.groupBox1.Controls.Add(this.btnAbrirPorta);
            this.groupBox1.Location = new System.Drawing.Point(519, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // cboVelocidade
            // 
            this.cboVelocidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVelocidade.FormattingEnabled = true;
            this.cboVelocidade.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboVelocidade.Location = new System.Drawing.Point(181, 29);
            this.cboVelocidade.Name = "cboVelocidade";
            this.cboVelocidade.Size = new System.Drawing.Size(163, 21);
            this.cboVelocidade.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Velocidade:";
            // 
            // cboParidade
            // 
            this.cboParidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParidade.FormattingEnabled = true;
            this.cboParidade.Location = new System.Drawing.Point(350, 29);
            this.cboParidade.Name = "cboParidade";
            this.cboParidade.Size = new System.Drawing.Size(163, 21);
            this.cboParidade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Paridade:";
            // 
            // cboBitDados
            // 
            this.cboBitDados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitDados.FormattingEnabled = true;
            this.cboBitDados.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboBitDados.Location = new System.Drawing.Point(12, 76);
            this.cboBitDados.Name = "cboBitDados";
            this.cboBitDados.Size = new System.Drawing.Size(163, 21);
            this.cboBitDados.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bit de Dados:";
            // 
            // cboBitParada
            // 
            this.cboBitParada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBitParada.FormattingEnabled = true;
            this.cboBitParada.Location = new System.Drawing.Point(181, 76);
            this.cboBitParada.Name = "cboBitParada";
            this.cboBitParada.Size = new System.Drawing.Size(163, 21);
            this.cboBitParada.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bit de Parada:";
            // 
            // serial
            // 
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // btnAbrirPorta
            // 
            this.btnAbrirPorta.Location = new System.Drawing.Point(6, 19);
            this.btnAbrirPorta.Name = "btnAbrirPorta";
            this.btnAbrirPorta.Size = new System.Drawing.Size(156, 23);
            this.btnAbrirPorta.TabIndex = 0;
            this.btnAbrirPorta.Text = "Abrir Porta";
            this.btnAbrirPorta.UseVisualStyleBackColor = true;
            this.btnAbrirPorta.Click += new System.EventHandler(this.btnAbrirPorta_Click);
            // 
            // btnFecharPorta
            // 
            this.btnFecharPorta.Location = new System.Drawing.Point(4, 48);
            this.btnFecharPorta.Name = "btnFecharPorta";
            this.btnFecharPorta.Size = new System.Drawing.Size(156, 23);
            this.btnFecharPorta.TabIndex = 1;
            this.btnFecharPorta.Text = "Fechar Porta";
            this.btnFecharPorta.UseVisualStyleBackColor = true;
            this.btnFecharPorta.Click += new System.EventHandler(this.btnFecharPorta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(4, 77);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(156, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnviar);
            this.groupBox2.Controls.Add(this.txtTransmissao);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 148);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transmissão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Conteúdo:";
            // 
            // txtTransmissao
            // 
            this.txtTransmissao.Location = new System.Drawing.Point(10, 37);
            this.txtTransmissao.Multiline = true;
            this.txtTransmissao.Name = "txtTransmissao";
            this.txtTransmissao.Size = new System.Drawing.Size(657, 57);
            this.txtTransmissao.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(557, 100);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(110, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRecepcao);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 148);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmissão";
            // 
            // txtRecepcao
            // 
            this.txtRecepcao.Location = new System.Drawing.Point(10, 37);
            this.txtRecepcao.Multiline = true;
            this.txtRecepcao.Name = "txtRecepcao";
            this.txtRecepcao.Size = new System.Drawing.Size(657, 105);
            this.txtRecepcao.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Recepção";
            // 
            // frmSerialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboBitParada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboBitDados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboParidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboVelocidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboPorta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSerialMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Monitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPorta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboVelocidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboParidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboBitDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboBitParada;
        private System.Windows.Forms.Label label5;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFecharPorta;
        private System.Windows.Forms.Button btnAbrirPorta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtTransmissao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRecepcao;
        private System.Windows.Forms.Label label7;
    }
}

