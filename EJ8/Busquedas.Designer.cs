﻿namespace EJ8
{
    partial class Busquedas
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
            this.TipoBusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busqueda por: ";
            // 
            // TipoBusqueda
            // 
            this.TipoBusqueda.AutoSize = true;
            this.TipoBusqueda.Location = new System.Drawing.Point(110, 27);
            this.TipoBusqueda.Name = "TipoBusqueda";
            this.TipoBusqueda.Size = new System.Drawing.Size(76, 13);
            this.TipoBusqueda.TabIndex = 1;
            this.TipoBusqueda.Text = "TipoBusqueda";
            // 
            // Busquedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 274);
            this.Controls.Add(this.TipoBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "Busquedas";
            this.Text = "Busquedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TipoBusqueda;
    }
}