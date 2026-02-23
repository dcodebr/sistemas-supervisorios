namespace Capitulo_9.WinForms
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
            this.btnFecharPorta = new System.Windows.Forms.Button();
            this.btnAbrirPorta = new System.Windows.Forms.Button();
            this.cboVelocidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboParidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboBitDados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBitParada = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblControle = new System.Windows.Forms.Label();
            this.btnInicia = new System.Windows.Forms.Button();
            this.btnFinaliza = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.btnFecharPorta);
            this.groupBox1.Controls.Add(this.btnAbrirPorta);
            this.groupBox1.Location = new System.Drawing.Point(519, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFinaliza);
            this.groupBox2.Controls.Add(this.btnInicia);
            this.groupBox2.Controls.Add(this.lblControle);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 154);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControle.Location = new System.Drawing.Point(26, 37);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(172, 75);
            this.lblControle.TabIndex = 0;
            this.lblControle.Text = "0000";
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(214, 51);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(75, 23);
            this.btnInicia.TabIndex = 1;
            this.btnInicia.Text = "Iniciar";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Location = new System.Drawing.Point(214, 80);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(75, 23);
            this.btnFinaliza.TabIndex = 2;
            this.btnFinaliza.Text = "Finalizar";
            this.btnFinaliza.UseVisualStyleBackColor = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // frmSerialMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 262);
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
        private System.Windows.Forms.Button btnFecharPorta;
        private System.Windows.Forms.Button btnAbrirPorta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinaliza;
        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.Label lblControle;
    }
}

