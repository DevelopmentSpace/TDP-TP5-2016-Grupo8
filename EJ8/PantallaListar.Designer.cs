namespace EJ8
{
    partial class PantallaListar
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
            this.TipoListado = new System.Windows.Forms.Label();
            this.usuariosEncontrados = new System.Windows.Forms.DataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosEncontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de listado:";
            // 
            // TipoListado
            // 
            this.TipoListado.AutoSize = true;
            this.TipoListado.Location = new System.Drawing.Point(125, 42);
            this.TipoListado.Name = "TipoListado";
            this.TipoListado.Size = new System.Drawing.Size(76, 13);
            this.TipoListado.TabIndex = 1;
            this.TipoListado.Text = "Tipo de listado";
            // 
            // usuariosEncontrados
            // 
            this.usuariosEncontrados.AllowUserToAddRows = false;
            this.usuariosEncontrados.AllowUserToDeleteRows = false;
            this.usuariosEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosEncontrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaNombre,
            this.columnaCorreo});
            this.usuariosEncontrados.Location = new System.Drawing.Point(42, 100);
            this.usuariosEncontrados.Name = "usuariosEncontrados";
            this.usuariosEncontrados.ReadOnly = true;
            this.usuariosEncontrados.Size = new System.Drawing.Size(343, 167);
            this.usuariosEncontrados.TabIndex = 2;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "Codigo";
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.ReadOnly = true;
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            // 
            // columnaCorreo
            // 
            this.columnaCorreo.HeaderText = "Correo electronico";
            this.columnaCorreo.Name = "columnaCorreo";
            this.columnaCorreo.ReadOnly = true;
            // 
            // PantallaListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 304);
            this.Controls.Add(this.usuariosEncontrados);
            this.Controls.Add(this.TipoListado);
            this.Controls.Add(this.label1);
            this.Name = "PantallaListar";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.PantallaListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosEncontrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TipoListado;
        private System.Windows.Forms.DataGridView usuariosEncontrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCorreo;
    }
}