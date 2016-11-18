namespace EJ5
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
            this.calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opcionCirculo = new System.Windows.Forms.RadioButton();
            this.opcionTriangulo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opcionPerimetro = new System.Windows.Forms.RadioButton();
            this.opcionArea = new System.Windows.Forms.RadioButton();
            this.salir = new System.Windows.Forms.Button();
            this.punto1X = new System.Windows.Forms.TextBox();
            this.punto1Y = new System.Windows.Forms.TextBox();
            this.punto2X = new System.Windows.Forms.TextBox();
            this.punto2YoRadio = new System.Windows.Forms.TextBox();
            this.punto3X = new System.Windows.Forms.TextBox();
            this.punto3Y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(108, 280);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 0;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opcionCirculo);
            this.groupBox1.Controls.Add(this.opcionTriangulo);
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 78);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // opcionCirculo
            // 
            this.opcionCirculo.AutoSize = true;
            this.opcionCirculo.Location = new System.Drawing.Point(20, 44);
            this.opcionCirculo.Name = "opcionCirculo";
            this.opcionCirculo.Size = new System.Drawing.Size(57, 17);
            this.opcionCirculo.TabIndex = 1;
            this.opcionCirculo.TabStop = true;
            this.opcionCirculo.Text = "Circulo";
            this.opcionCirculo.UseVisualStyleBackColor = true;
            this.opcionCirculo.CheckedChanged += new System.EventHandler(this.opcionCirculo_CheckedChanged);
            // 
            // opcionTriangulo
            // 
            this.opcionTriangulo.AutoSize = true;
            this.opcionTriangulo.Checked = true;
            this.opcionTriangulo.Location = new System.Drawing.Point(20, 20);
            this.opcionTriangulo.Name = "opcionTriangulo";
            this.opcionTriangulo.Size = new System.Drawing.Size(69, 17);
            this.opcionTriangulo.TabIndex = 0;
            this.opcionTriangulo.TabStop = true;
            this.opcionTriangulo.Text = "Triangulo";
            this.opcionTriangulo.UseVisualStyleBackColor = true;
            this.opcionTriangulo.CheckedChanged += new System.EventHandler(this.opcionTriangulo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opcionPerimetro);
            this.groupBox2.Controls.Add(this.opcionArea);
            this.groupBox2.Location = new System.Drawing.Point(195, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcular";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // opcionPerimetro
            // 
            this.opcionPerimetro.AutoSize = true;
            this.opcionPerimetro.Location = new System.Drawing.Point(19, 42);
            this.opcionPerimetro.Name = "opcionPerimetro";
            this.opcionPerimetro.Size = new System.Drawing.Size(69, 17);
            this.opcionPerimetro.TabIndex = 1;
            this.opcionPerimetro.TabStop = true;
            this.opcionPerimetro.Text = "Perimetro";
            this.opcionPerimetro.UseVisualStyleBackColor = true;
            // 
            // opcionArea
            // 
            this.opcionArea.AutoSize = true;
            this.opcionArea.Checked = true;
            this.opcionArea.Location = new System.Drawing.Point(20, 19);
            this.opcionArea.Name = "opcionArea";
            this.opcionArea.Size = new System.Drawing.Size(47, 17);
            this.opcionArea.TabIndex = 0;
            this.opcionArea.TabStop = true;
            this.opcionArea.Text = "Area";
            this.opcionArea.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(232, 280);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_click);
            // 
            // punto1X
            // 
            this.punto1X.Location = new System.Drawing.Point(53, 140);
            this.punto1X.Name = "punto1X";
            this.punto1X.Size = new System.Drawing.Size(100, 20);
            this.punto1X.TabIndex = 4;
            // 
            // punto1Y
            // 
            this.punto1Y.Location = new System.Drawing.Point(243, 140);
            this.punto1Y.Name = "punto1Y";
            this.punto1Y.Size = new System.Drawing.Size(100, 20);
            this.punto1Y.TabIndex = 5;
            // 
            // punto2X
            // 
            this.punto2X.Location = new System.Drawing.Point(54, 183);
            this.punto2X.Name = "punto2X";
            this.punto2X.Size = new System.Drawing.Size(100, 20);
            this.punto2X.TabIndex = 6;
            // 
            // punto2YoRadio
            // 
            this.punto2YoRadio.Location = new System.Drawing.Point(243, 183);
            this.punto2YoRadio.Name = "punto2YoRadio";
            this.punto2YoRadio.Size = new System.Drawing.Size(100, 20);
            this.punto2YoRadio.TabIndex = 7;
            // 
            // punto3X
            // 
            this.punto3X.Location = new System.Drawing.Point(53, 231);
            this.punto3X.Name = "punto3X";
            this.punto3X.Size = new System.Drawing.Size(100, 20);
            this.punto3X.TabIndex = 8;
            // 
            // punto3Y
            // 
            this.punto3Y.Location = new System.Drawing.Point(243, 231);
            this.punto3Y.Name = "punto3Y";
            this.punto3Y.Size = new System.Drawing.Size(100, 20);
            this.punto3Y.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Radio";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Punto1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Punto2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Punto3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 323);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.punto3Y);
            this.Controls.Add(this.punto3X);
            this.Controls.Add(this.punto2YoRadio);
            this.Controls.Add(this.punto2X);
            this.Controls.Add(this.punto1Y);
            this.Controls.Add(this.punto1X);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calcular);
            this.Name = "Form1";
            this.Text = "Calculo de areas y permitros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton opcionCirculo;
        private System.Windows.Forms.RadioButton opcionTriangulo;
        private System.Windows.Forms.RadioButton opcionPerimetro;
        private System.Windows.Forms.RadioButton opcionArea;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox punto1X;
        private System.Windows.Forms.TextBox punto1Y;
        private System.Windows.Forms.TextBox punto2X;
        private System.Windows.Forms.TextBox punto2YoRadio;
        private System.Windows.Forms.TextBox punto3X;
        private System.Windows.Forms.TextBox punto3Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

