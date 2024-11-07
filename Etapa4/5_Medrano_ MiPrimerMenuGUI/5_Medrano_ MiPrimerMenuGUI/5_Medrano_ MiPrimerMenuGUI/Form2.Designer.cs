namespace _5_Medrano__MiPrimerMenuGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUM1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NUM2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VOLVER = new System.Windows.Forms.Button();
            this.CER2 = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(263, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE  EL PRIMER NÚMERO:\r\n\r\n";
            
            // 
            // NUM1
            // 
            this.NUM1.Location = new System.Drawing.Point(136, 178);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(100, 20);
            this.NUM1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightPink;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "INGRESE EL SEGUNDO NÚMERO:";
            // 
            // NUM2
            // 
            this.NUM2.Location = new System.Drawing.Point(346, 177);
            this.NUM2.Name = "NUM2";
            this.NUM2.Size = new System.Drawing.Size(100, 20);
            this.NUM2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "RESULTADO DE LA SUMA:";
            // 
            // VOLVER
            // 
            this.VOLVER.Location = new System.Drawing.Point(438, 375);
            this.VOLVER.Name = "VOLVER";
            this.VOLVER.Size = new System.Drawing.Size(123, 23);
            this.VOLVER.TabIndex = 7;
            this.VOLVER.Text = "VOLVER AL MENÚ";
            this.VOLVER.UseVisualStyleBackColor = true;
            this.VOLVER.Click += new System.EventHandler(this.VOLVER_Click);
            // 
            // CER2
            // 
            this.CER2.Location = new System.Drawing.Point(136, 394);
            this.CER2.Name = "CER2";
            this.CER2.Size = new System.Drawing.Size(75, 23);
            this.CER2.TabIndex = 8;
            this.CER2.Text = "CERRAR";
            this.CER2.UseVisualStyleBackColor = true;
            this.CER2.Click += new System.EventHandler(this.CER2_Click);
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(272, 408);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 9;
            this.calcular.Text = "calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(333, 281);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(591, 491);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.CER2);
            this.Controls.Add(this.VOLVER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUM2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUM1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NUM1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NUM2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button VOLVER;
        private System.Windows.Forms.Button CER2;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label resultado;
    }
}