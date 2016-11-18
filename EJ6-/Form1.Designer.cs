namespace EJ6_
{
    partial class Form1
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
            this.transferenciaCAaCC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaldoCuentaCorriente = new System.Windows.Forms.Label();
            this.SaldoCajaAhorro = new System.Windows.Forms.Label();
            this.transferenciaCCaCA = new System.Windows.Forms.Button();
            this.MontoAUsar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NomYApeCliente = new System.Windows.Forms.Label();
            this.debitarCajaAhorro = new System.Windows.Forms.Button();
            this.debitarCuentaCorriente = new System.Windows.Forms.Button();
            this.acreditarCajaAhorro = new System.Windows.Forms.Button();
            this.acreditarCuentaCorriente = new System.Windows.Forms.Button();
            this.grupoTransferencias = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.acreditaciones = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grupoTransferencias.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.acreditaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // transferenciaCAaCC
            // 
            this.transferenciaCAaCC.Location = new System.Drawing.Point(6, 25);
            this.transferenciaCAaCC.Name = "transferenciaCAaCC";
            this.transferenciaCAaCC.Size = new System.Drawing.Size(180, 26);
            this.transferenciaCAaCC.TabIndex = 0;
            this.transferenciaCAaCC.Text = "Caja ahorro a cuenta corriente";
            this.transferenciaCAaCC.UseVisualStyleBackColor = true;
            this.transferenciaCAaCC.Click += new System.EventHandler(this.transferirCCaCA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banco Triunfante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dinero en cuenta corriente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dinero en caja de ahorro:";
            // 
            // SaldoCuentaCorriente
            // 
            this.SaldoCuentaCorriente.AutoSize = true;
            this.SaldoCuentaCorriente.Location = new System.Drawing.Point(333, 73);
            this.SaldoCuentaCorriente.Name = "SaldoCuentaCorriente";
            this.SaldoCuentaCorriente.Size = new System.Drawing.Size(114, 13);
            this.SaldoCuentaCorriente.TabIndex = 4;
            this.SaldoCuentaCorriente.Text = "Saldo cuenta corriente";
            // 
            // SaldoCajaAhorro
            // 
            this.SaldoCajaAhorro.AutoSize = true;
            this.SaldoCajaAhorro.Location = new System.Drawing.Point(333, 101);
            this.SaldoCajaAhorro.Name = "SaldoCajaAhorro";
            this.SaldoCajaAhorro.Size = new System.Drawing.Size(90, 13);
            this.SaldoCajaAhorro.TabIndex = 5;
            this.SaldoCajaAhorro.Text = "Saldo caja ahorro";
            // 
            // transferenciaCCaCA
            // 
            this.transferenciaCCaCA.Location = new System.Drawing.Point(6, 59);
            this.transferenciaCCaCA.Name = "transferenciaCCaCA";
            this.transferenciaCCaCA.Size = new System.Drawing.Size(180, 25);
            this.transferenciaCCaCA.TabIndex = 7;
            this.transferenciaCCaCA.Text = "Cuenta corriente a caja ahorro";
            this.transferenciaCCaCA.UseVisualStyleBackColor = true;
            this.transferenciaCCaCA.Click += new System.EventHandler(this.transferirCAaCC_Click);
            // 
            // MontoAUsar
            // 
            this.MontoAUsar.Location = new System.Drawing.Point(223, 144);
            this.MontoAUsar.Name = "MontoAUsar";
            this.MontoAUsar.Size = new System.Drawing.Size(100, 20);
            this.MontoAUsar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Monto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bienvenido:";
            // 
            // NomYApeCliente
            // 
            this.NomYApeCliente.AutoSize = true;
            this.NomYApeCliente.Location = new System.Drawing.Point(161, 38);
            this.NomYApeCliente.Name = "NomYApeCliente";
            this.NomYApeCliente.Size = new System.Drawing.Size(0, 13);
            this.NomYApeCliente.TabIndex = 11;
            // 
            // debitarCajaAhorro
            // 
            this.debitarCajaAhorro.Location = new System.Drawing.Point(46, 23);
            this.debitarCajaAhorro.Name = "debitarCajaAhorro";
            this.debitarCajaAhorro.Size = new System.Drawing.Size(75, 23);
            this.debitarCajaAhorro.TabIndex = 14;
            this.debitarCajaAhorro.Text = "Caja ahorro";
            this.debitarCajaAhorro.UseVisualStyleBackColor = true;
            this.debitarCajaAhorro.Click += new System.EventHandler(this.debitarCajaAhorro_Click);
            // 
            // debitarCuentaCorriente
            // 
            this.debitarCuentaCorriente.Location = new System.Drawing.Point(34, 57);
            this.debitarCuentaCorriente.Name = "debitarCuentaCorriente";
            this.debitarCuentaCorriente.Size = new System.Drawing.Size(101, 23);
            this.debitarCuentaCorriente.TabIndex = 15;
            this.debitarCuentaCorriente.Text = "Cuenta corriente";
            this.debitarCuentaCorriente.UseVisualStyleBackColor = true;
            this.debitarCuentaCorriente.Click += new System.EventHandler(this.debitarCuentaCorriente_Click);
            // 
            // acreditarCajaAhorro
            // 
            this.acreditarCajaAhorro.Location = new System.Drawing.Point(34, 23);
            this.acreditarCajaAhorro.Name = "acreditarCajaAhorro";
            this.acreditarCajaAhorro.Size = new System.Drawing.Size(75, 23);
            this.acreditarCajaAhorro.TabIndex = 16;
            this.acreditarCajaAhorro.Text = "Caja ahorro";
            this.acreditarCajaAhorro.UseVisualStyleBackColor = true;
            this.acreditarCajaAhorro.Click += new System.EventHandler(this.acreditarCajaAhorro_Click);
            // 
            // acreditarCuentaCorriente
            // 
            this.acreditarCuentaCorriente.Location = new System.Drawing.Point(22, 57);
            this.acreditarCuentaCorriente.Name = "acreditarCuentaCorriente";
            this.acreditarCuentaCorriente.Size = new System.Drawing.Size(99, 25);
            this.acreditarCuentaCorriente.TabIndex = 17;
            this.acreditarCuentaCorriente.Text = "Cuenta corriente";
            this.acreditarCuentaCorriente.UseVisualStyleBackColor = true;
            this.acreditarCuentaCorriente.Click += new System.EventHandler(this.acreditarCuentaCorriente_Click);
            // 
            // grupoTransferencias
            // 
            this.grupoTransferencias.Controls.Add(this.transferenciaCAaCC);
            this.grupoTransferencias.Controls.Add(this.transferenciaCCaCA);
            this.grupoTransferencias.Location = new System.Drawing.Point(61, 183);
            this.grupoTransferencias.Name = "grupoTransferencias";
            this.grupoTransferencias.Size = new System.Drawing.Size(200, 100);
            this.grupoTransferencias.TabIndex = 18;
            this.grupoTransferencias.TabStop = false;
            this.grupoTransferencias.Text = "Transferencias";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.debitarCajaAhorro);
            this.groupBox1.Controls.Add(this.debitarCuentaCorriente);
            this.groupBox1.Location = new System.Drawing.Point(271, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 96);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debitaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // acreditaciones
            // 
            this.acreditaciones.Controls.Add(this.acreditarCajaAhorro);
            this.acreditaciones.Controls.Add(this.acreditarCuentaCorriente);
            this.acreditaciones.Location = new System.Drawing.Point(459, 185);
            this.acreditaciones.Name = "acreditaciones";
            this.acreditaciones.Size = new System.Drawing.Size(146, 98);
            this.acreditaciones.TabIndex = 20;
            this.acreditaciones.TabStop = false;
            this.acreditaciones.Text = "Acreditaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "(Ingrese aqui el monto a usar en las operaciones)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomYApeCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MontoAUsar);
            this.Controls.Add(this.SaldoCajaAhorro);
            this.Controls.Add(this.SaldoCuentaCorriente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grupoTransferencias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.acreditaciones);
            this.Name = "Form1";
            this.Text = "Administrador de cuentas - Triunfante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupoTransferencias.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.acreditaciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferenciaCAaCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SaldoCuentaCorriente;
        private System.Windows.Forms.Label SaldoCajaAhorro;
        private System.Windows.Forms.Button transferenciaCCaCA;
        private System.Windows.Forms.TextBox MontoAUsar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NomYApeCliente;
        private System.Windows.Forms.Button debitarCajaAhorro;
        private System.Windows.Forms.Button debitarCuentaCorriente;
        private System.Windows.Forms.Button acreditarCajaAhorro;
        private System.Windows.Forms.Button acreditarCuentaCorriente;
        private System.Windows.Forms.GroupBox grupoTransferencias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox acreditaciones;
        private System.Windows.Forms.Label label4;
    }
}

