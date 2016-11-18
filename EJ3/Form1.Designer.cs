namespace EJ3
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
            this.OpcionNumero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Traduccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpcionNumero
            // 
            this.OpcionNumero.FormattingEnabled = true;
            this.OpcionNumero.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve",
            "Diez"});
            this.OpcionNumero.Location = new System.Drawing.Point(145, 45);
            this.OpcionNumero.Name = "OpcionNumero";
            this.OpcionNumero.Size = new System.Drawing.Size(121, 21);
            this.OpcionNumero.TabIndex = 0;
            this.OpcionNumero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.OpcionNumero.SelectionChangeCommitted += new System.EventHandler(this.OpcionNumero_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Traduccion:";
            // 
            // Traduccion
            // 
            this.Traduccion.AutoSize = true;
            this.Traduccion.Location = new System.Drawing.Point(216, 120);
            this.Traduccion.Name = "Traduccion";
            this.Traduccion.Size = new System.Drawing.Size(0, 13);
            this.Traduccion.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 166);
            this.Controls.Add(this.Traduccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpcionNumero);
            this.Name = "Form1";
            this.Text = "TraducirNumero";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OpcionNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Traduccion;
    }
}

