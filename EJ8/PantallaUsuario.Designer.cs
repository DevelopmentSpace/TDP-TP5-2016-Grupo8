namespace EJ8
{
    partial class PantallaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codigoUsuario = new System.Windows.Forms.TextBox();
            this.nombreYapellidoUsuario = new System.Windows.Forms.TextBox();
            this.correoUsuario = new System.Windows.Forms.TextBox();
            this.AceptarAccion = new System.Windows.Forms.Button();
            this.CancelarAccion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AccionEjecutarse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo electronico:";
            // 
            // codigoUsuario
            // 
            this.codigoUsuario.Location = new System.Drawing.Point(140, 55);
            this.codigoUsuario.Name = "codigoUsuario";
            this.codigoUsuario.Size = new System.Drawing.Size(100, 20);
            this.codigoUsuario.TabIndex = 3;
            this.codigoUsuario.TextChanged += new System.EventHandler(this.codigoUsuario_TextChanged);
            // 
            // nombreYapellidoUsuario
            // 
            this.nombreYapellidoUsuario.Location = new System.Drawing.Point(140, 113);
            this.nombreYapellidoUsuario.Name = "nombreYapellidoUsuario";
            this.nombreYapellidoUsuario.Size = new System.Drawing.Size(100, 20);
            this.nombreYapellidoUsuario.TabIndex = 4;
            // 
            // correoUsuario
            // 
            this.correoUsuario.Location = new System.Drawing.Point(140, 169);
            this.correoUsuario.Name = "correoUsuario";
            this.correoUsuario.Size = new System.Drawing.Size(100, 20);
            this.correoUsuario.TabIndex = 5;
            // 
            // AceptarAccion
            // 
            this.AceptarAccion.Location = new System.Drawing.Point(41, 222);
            this.AceptarAccion.Name = "AceptarAccion";
            this.AceptarAccion.Size = new System.Drawing.Size(75, 23);
            this.AceptarAccion.TabIndex = 6;
            this.AceptarAccion.Text = "Aceptar";
            this.AceptarAccion.UseVisualStyleBackColor = true;
            this.AceptarAccion.Click += new System.EventHandler(this.AceptarAccion_Click);
            // 
            // CancelarAccion
            // 
            this.CancelarAccion.Location = new System.Drawing.Point(191, 222);
            this.CancelarAccion.Name = "CancelarAccion";
            this.CancelarAccion.Size = new System.Drawing.Size(75, 23);
            this.CancelarAccion.TabIndex = 8;
            this.CancelarAccion.Text = "Cancelar";
            this.CancelarAccion.UseVisualStyleBackColor = true;
            this.CancelarAccion.Click += new System.EventHandler(this.CancelarAccion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Accion:";
            // 
            // AccionEjecutarse
            // 
            this.AccionEjecutarse.AutoSize = true;
            this.AccionEjecutarse.Location = new System.Drawing.Point(98, 13);
            this.AccionEjecutarse.Name = "AccionEjecutarse";
            this.AccionEjecutarse.Size = new System.Drawing.Size(77, 13);
            this.AccionEjecutarse.TabIndex = 10;
            this.AccionEjecutarse.Text = "NombreAccion";
            // 
            // PantallaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 271);
            this.Controls.Add(this.AccionEjecutarse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelarAccion);
            this.Controls.Add(this.AceptarAccion);
            this.Controls.Add(this.correoUsuario);
            this.Controls.Add(this.nombreYapellidoUsuario);
            this.Controls.Add(this.codigoUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PantallaUsuario";
            this.Text = "Pantalla Usuario";
            this.Load += new System.EventHandler(this.PantallaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codigoUsuario;
        private System.Windows.Forms.TextBox nombreYapellidoUsuario;
        private System.Windows.Forms.TextBox correoUsuario;
        private System.Windows.Forms.Button AceptarAccion;
        private System.Windows.Forms.Button CancelarAccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AccionEjecutarse;
    }
}