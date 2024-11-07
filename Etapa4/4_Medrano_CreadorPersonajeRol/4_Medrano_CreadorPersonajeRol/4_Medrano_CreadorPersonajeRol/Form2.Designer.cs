namespace _4_Medrano_CreadorPersonajeRol
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre2 = new System.Windows.Forms.TextBox();
            this.vida2 = new System.Windows.Forms.TextBox();
            this.raza2 = new System.Windows.Forms.TextBox();
            this.habilidades2 = new System.Windows.Forms.TextBox();
            this.boton2 = new System.Windows.Forms.Button();
            this.BOTCER2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Habilidades Extra: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Raza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vida: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre: ";
            // 
            // nombre2
            // 
            this.nombre2.Location = new System.Drawing.Point(29, 88);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(100, 20);
            this.nombre2.TabIndex = 12;
            // 
            // vida2
            // 
            this.vida2.Location = new System.Drawing.Point(178, 87);
            this.vida2.Name = "vida2";
            this.vida2.Size = new System.Drawing.Size(100, 20);
            this.vida2.TabIndex = 13;
            // 
            // raza2
            // 
            this.raza2.Location = new System.Drawing.Point(319, 87);
            this.raza2.Name = "raza2";
            this.raza2.Size = new System.Drawing.Size(100, 20);
            this.raza2.TabIndex = 14;
            // 
            // habilidades2
            // 
            this.habilidades2.Location = new System.Drawing.Point(467, 87);
            this.habilidades2.Name = "habilidades2";
            this.habilidades2.Size = new System.Drawing.Size(100, 20);
            this.habilidades2.TabIndex = 15;
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(411, 254);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(75, 23);
            this.boton2.TabIndex = 16;
            this.boton2.Text = "atras";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // BOTCER2
            // 
            this.BOTCER2.Location = new System.Drawing.Point(207, 254);
            this.BOTCER2.Name = "BOTCER2";
            this.BOTCER2.Size = new System.Drawing.Size(75, 23);
            this.BOTCER2.TabIndex = 17;
            this.BOTCER2.Text = "CERRAR";
            this.BOTCER2.UseVisualStyleBackColor = true;
            this.BOTCER2.Click += new System.EventHandler(this.BOTCER2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 316);
            this.Controls.Add(this.BOTCER2);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.habilidades2);
            this.Controls.Add(this.raza2);
            this.Controls.Add(this.vida2);
            this.Controls.Add(this.nombre2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre2;
        private System.Windows.Forms.TextBox vida2;
        private System.Windows.Forms.TextBox raza2;
        private System.Windows.Forms.TextBox habilidades2;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button BOTCER2;
    }
}