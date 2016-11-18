namespace EJ2
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
            this.RadioBoton1 = new System.Windows.Forms.RadioButton();
            this.RadioBoton2 = new System.Windows.Forms.RadioButton();
            this.RadioBoton3 = new System.Windows.Forms.RadioButton();
            this.Caja1 = new System.Windows.Forms.CheckBox();
            this.Caja2 = new System.Windows.Forms.CheckBox();
            this.Verificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioBoton1
            // 
            this.RadioBoton1.AutoSize = true;
            this.RadioBoton1.Location = new System.Drawing.Point(38, 61);
            this.RadioBoton1.Name = "RadioBoton1";
            this.RadioBoton1.Size = new System.Drawing.Size(65, 17);
            this.RadioBoton1.TabIndex = 0;
            this.RadioBoton1.TabStop = true;
            this.RadioBoton1.Text = "Opcion1";
            this.RadioBoton1.UseVisualStyleBackColor = true;
            this.RadioBoton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioBoton2
            // 
            this.RadioBoton2.AutoSize = true;
            this.RadioBoton2.Location = new System.Drawing.Point(38, 85);
            this.RadioBoton2.Name = "RadioBoton2";
            this.RadioBoton2.Size = new System.Drawing.Size(65, 17);
            this.RadioBoton2.TabIndex = 1;
            this.RadioBoton2.TabStop = true;
            this.RadioBoton2.Text = "Opcion2";
            this.RadioBoton2.UseVisualStyleBackColor = true;
            this.RadioBoton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RadioBoton3
            // 
            this.RadioBoton3.AutoSize = true;
            this.RadioBoton3.Location = new System.Drawing.Point(38, 109);
            this.RadioBoton3.Name = "RadioBoton3";
            this.RadioBoton3.Size = new System.Drawing.Size(65, 17);
            this.RadioBoton3.TabIndex = 2;
            this.RadioBoton3.TabStop = true;
            this.RadioBoton3.Text = "Opcion3";
            this.RadioBoton3.UseVisualStyleBackColor = true;
            this.RadioBoton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Caja1
            // 
            this.Caja1.AutoSize = true;
            this.Caja1.Location = new System.Drawing.Point(164, 61);
            this.Caja1.Name = "Caja1";
            this.Caja1.Size = new System.Drawing.Size(53, 17);
            this.Caja1.TabIndex = 3;
            this.Caja1.Text = "Caja1";
            this.Caja1.UseVisualStyleBackColor = true;
            this.Caja1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Caja2
            // 
            this.Caja2.AutoSize = true;
            this.Caja2.Location = new System.Drawing.Point(164, 85);
            this.Caja2.Name = "Caja2";
            this.Caja2.Size = new System.Drawing.Size(53, 17);
            this.Caja2.TabIndex = 4;
            this.Caja2.Text = "Caja2";
            this.Caja2.UseVisualStyleBackColor = true;
            this.Caja2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(140, 171);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(75, 23);
            this.Verificar.TabIndex = 5;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Click_Verificar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 225);
            this.Controls.Add(this.Verificar);
            this.Controls.Add(this.Caja2);
            this.Controls.Add(this.Caja1);
            this.Controls.Add(this.RadioBoton3);
            this.Controls.Add(this.RadioBoton2);
            this.Controls.Add(this.RadioBoton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioBoton1;
        private System.Windows.Forms.RadioButton RadioBoton2;
        private System.Windows.Forms.RadioButton RadioBoton3;
        private System.Windows.Forms.CheckBox Caja1;
        private System.Windows.Forms.CheckBox Caja2;
        private System.Windows.Forms.Button Verificar;
    }
}

