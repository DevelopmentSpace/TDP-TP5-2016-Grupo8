namespace EJ7
{
    partial class Principal
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
            this.listaEncriptadores = new System.Windows.Forms.ComboBox();
            this.textoSinEncriptar = new System.Windows.Forms.RichTextBox();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.textoEncriptado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpcionEncriptar = new System.Windows.Forms.RadioButton();
            this.OpcionDescencriptar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listaEncriptadores
            // 
            this.listaEncriptadores.Items.AddRange(new object[] {
            "Clasico",
            "AES",
            "César",
            "Nulo"});
            this.listaEncriptadores.Location = new System.Drawing.Point(131, 167);
            this.listaEncriptadores.Name = "listaEncriptadores";
            this.listaEncriptadores.Size = new System.Drawing.Size(121, 21);
            this.listaEncriptadores.TabIndex = 0;
            this.listaEncriptadores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textoSinEncriptar
            // 
            this.textoSinEncriptar.Location = new System.Drawing.Point(145, 31);
            this.textoSinEncriptar.Name = "textoSinEncriptar";
            this.textoSinEncriptar.Size = new System.Drawing.Size(288, 116);
            this.textoSinEncriptar.TabIndex = 1;
            this.textoSinEncriptar.Text = "";
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Location = new System.Drawing.Point(285, 165);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(75, 23);
            this.BotonCalcular.TabIndex = 2;
            this.BotonCalcular.Text = "Calcular";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // textoEncriptado
            // 
            this.textoEncriptado.Location = new System.Drawing.Point(145, 224);
            this.textoEncriptado.Name = "textoEncriptado";
            this.textoEncriptado.Size = new System.Drawing.Size(288, 109);
            this.textoEncriptado.TabIndex = 3;
            this.textoEncriptado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Texto sin encriptar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto encriptado";
            // 
            // OpcionEncriptar
            // 
            this.OpcionEncriptar.AutoSize = true;
            this.OpcionEncriptar.Checked = true;
            this.OpcionEncriptar.Location = new System.Drawing.Point(367, 154);
            this.OpcionEncriptar.Name = "OpcionEncriptar";
            this.OpcionEncriptar.Size = new System.Drawing.Size(67, 17);
            this.OpcionEncriptar.TabIndex = 6;
            this.OpcionEncriptar.TabStop = true;
            this.OpcionEncriptar.Text = "Encriptar";
            this.OpcionEncriptar.UseVisualStyleBackColor = true;
            this.OpcionEncriptar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OpcionDescencriptar
            // 
            this.OpcionDescencriptar.AutoSize = true;
            this.OpcionDescencriptar.Location = new System.Drawing.Point(367, 178);
            this.OpcionDescencriptar.Name = "OpcionDescencriptar";
            this.OpcionDescencriptar.Size = new System.Drawing.Size(91, 17);
            this.OpcionDescencriptar.TabIndex = 7;
            this.OpcionDescencriptar.TabStop = true;
            this.OpcionDescencriptar.Text = "Descencriptar";
            this.OpcionDescencriptar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 358);
            this.Controls.Add(this.OpcionDescencriptar);
            this.Controls.Add(this.OpcionEncriptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoEncriptado);
            this.Controls.Add(this.BotonCalcular);
            this.Controls.Add(this.textoSinEncriptar);
            this.Controls.Add(this.listaEncriptadores);
            this.Name = "Form1";
            this.Text = "Encriptador - Descencriptador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaEncriptadores;
        private System.Windows.Forms.RichTextBox textoSinEncriptar;
        private System.Windows.Forms.Button BotonCalcular;
        private System.Windows.Forms.RichTextBox textoEncriptado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton OpcionEncriptar;
        private System.Windows.Forms.RadioButton OpcionDescencriptar;
    }
}

