﻿namespace _1_Medrano_CobrarBecaGUI
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
            this.EDAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SALARIO = new System.Windows.Forms.ComboBox();
            this.BOTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "COBRAR BECA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "EDAD:";
            // 
            // EDAD
            // 
            this.EDAD.Location = new System.Drawing.Point(78, 100);
            this.EDAD.Name = "EDAD";
            this.EDAD.Size = new System.Drawing.Size(100, 20);
            this.EDAD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "SALARIO:";
            // 
            // SALARIO
            // 
            this.SALARIO.FormattingEnabled = true;
            this.SALARIO.Items.AddRange(new object[] {
            "Entre 0 - 50,000",
            "50,001 - 100,000",
            "100,001 - 200,000",
            "Más de 200,000"});
            this.SALARIO.Location = new System.Drawing.Point(78, 206);
            this.SALARIO.Name = "SALARIO";
            this.SALARIO.Size = new System.Drawing.Size(121, 21);
            this.SALARIO.TabIndex = 4;
            // 
            // BOTON
            // 
            this.BOTON.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOTON.Location = new System.Drawing.Point(232, 261);
            this.BOTON.Name = "BOTON";
            this.BOTON.Size = new System.Drawing.Size(117, 23);
            this.BOTON.TabIndex = 5;
            this.BOTON.Text = "CONSULTAR";
            this.BOTON.UseVisualStyleBackColor = true;
            this.BOTON.Click += new System.EventHandler(this.BOTON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(579, 318);
            this.Controls.Add(this.BOTON);
            this.Controls.Add(this.SALARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EDAD);
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
        private System.Windows.Forms.TextBox EDAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SALARIO;
        private System.Windows.Forms.Button BOTON;
    }
}

