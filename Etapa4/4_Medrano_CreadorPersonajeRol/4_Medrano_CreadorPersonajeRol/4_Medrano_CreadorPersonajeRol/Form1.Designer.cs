namespace _4_Medrano_CreadorPersonajeRol
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Vida = new System.Windows.Forms.TextBox();
            this.Raza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.habilidades = new System.Windows.Forms.CheckedListBox();
            this.boton1 = new System.Windows.Forms.Button();
            this.butoncer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carga de Datos del Personaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre: ";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(25, 100);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vida: ";
            // 
            // Vida
            // 
            this.Vida.Location = new System.Drawing.Point(174, 100);
            this.Vida.Name = "Vida";
            this.Vida.Size = new System.Drawing.Size(100, 20);
            this.Vida.TabIndex = 4;
            // 
            // Raza
            // 
            this.Raza.FormattingEnabled = true;
            this.Raza.Items.AddRange(new object[] {
            "Humano",
            "Enano",
            "Hobbit"});
            this.Raza.Location = new System.Drawing.Point(312, 98);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(121, 21);
            this.Raza.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Raza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Habilidades Extra: ";
            // 
            // habilidades
            // 
            this.habilidades.FormattingEnabled = true;
            this.habilidades.Items.AddRange(new object[] {
            "Invisibilidad",
            "Fuerza Sobrehumana",
            "Curación Rápida"});
            this.habilidades.Location = new System.Drawing.Point(463, 115);
            this.habilidades.Name = "habilidades";
            this.habilidades.Size = new System.Drawing.Size(120, 64);
            this.habilidades.TabIndex = 8;
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(387, 239);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 23);
            this.boton1.TabIndex = 9;
            this.boton1.Text = "siguiente";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // butoncer
            // 
            this.butoncer.Location = new System.Drawing.Point(149, 239);
            this.butoncer.Name = "butoncer";
            this.butoncer.Size = new System.Drawing.Size(75, 23);
            this.butoncer.TabIndex = 10;
            this.butoncer.Text = "cerrar";
            this.butoncer.UseVisualStyleBackColor = true;
            this.butoncer.Click += new System.EventHandler(this.butoncer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 323);
            this.Controls.Add(this.butoncer);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.habilidades);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Raza);
            this.Controls.Add(this.Vida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Vida;
        private System.Windows.Forms.ComboBox Raza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox habilidades;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button butoncer;
    }
}

