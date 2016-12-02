namespace EJ8
{
    partial class PantallaBusqueda
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
            this.resultadoBusqueda = new System.Windows.Forms.DataGridView();
            this.ColumnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonBusqueda = new System.Windows.Forms.Button();
            this.textoBusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBusqueda)).BeginInit();
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
            // resultadoBusqueda
            // 
            this.resultadoBusqueda.AllowUserToAddRows = false;
            this.resultadoBusqueda.AllowUserToDeleteRows = false;
            this.resultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadoBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaCodigo,
            this.ColumnaNombre,
            this.ColumnaCorreo});
            this.resultadoBusqueda.Location = new System.Drawing.Point(45, 113);
            this.resultadoBusqueda.Name = "resultadoBusqueda";
            this.resultadoBusqueda.ReadOnly = true;
            this.resultadoBusqueda.Size = new System.Drawing.Size(343, 135);
            this.resultadoBusqueda.TabIndex = 2;
            // 
            // ColumnaCodigo
            // 
            this.ColumnaCodigo.HeaderText = "Codigo";
            this.ColumnaCodigo.Name = "ColumnaCodigo";
            this.ColumnaCodigo.ReadOnly = true;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaCorreo
            // 
            this.ColumnaCorreo.HeaderText = "Correo electronico";
            this.ColumnaCorreo.Name = "ColumnaCorreo";
            this.ColumnaCorreo.ReadOnly = true;
            // 
            // botonBusqueda
            // 
            this.botonBusqueda.Location = new System.Drawing.Point(231, 81);
            this.botonBusqueda.Name = "botonBusqueda";
            this.botonBusqueda.Size = new System.Drawing.Size(75, 23);
            this.botonBusqueda.TabIndex = 3;
            this.botonBusqueda.Text = "Buscar";
            this.botonBusqueda.UseVisualStyleBackColor = true;
            this.botonBusqueda.Click += new System.EventHandler(this.botonBusqueda_Click);
            // 
            // textoBusqueda
            // 
            this.textoBusqueda.Location = new System.Drawing.Point(113, 83);
            this.textoBusqueda.Name = "textoBusqueda";
            this.textoBusqueda.Size = new System.Drawing.Size(100, 20);
            this.textoBusqueda.TabIndex = 4;
            // 
            // PantallaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 274);
            this.Controls.Add(this.textoBusqueda);
            this.Controls.Add(this.botonBusqueda);
            this.Controls.Add(this.resultadoBusqueda);
            this.Controls.Add(this.TipoBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "PantallaBusqueda";
            this.Text = "Busquedas";
            this.Load += new System.EventHandler(this.PantallaBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TipoBusqueda;
        private System.Windows.Forms.DataGridView resultadoBusqueda;
        private System.Windows.Forms.Button botonBusqueda;
        private System.Windows.Forms.TextBox textoBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaCorreo;
    }
}