﻿namespace _5_Medrano__MiPrimerMenuGUI
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
            this.bot1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.CER1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(184, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO AL MENÚ \r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bot1
            // 
            this.bot1.BackColor = System.Drawing.Color.Pink;
            this.bot1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bot1.Location = new System.Drawing.Point(77, 183);
            this.bot1.Name = "bot1";
            this.bot1.Size = new System.Drawing.Size(75, 36);
            this.bot1.TabIndex = 1;
            this.bot1.Text = "SUMA";
            this.bot1.UseVisualStyleBackColor = false;
            this.bot1.Click += new System.EventHandler(this.button1_Click);
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.Color.Pink;
            this.but2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.but2.Location = new System.Drawing.Point(273, 183);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(75, 36);
            this.but2.TabIndex = 2;
            this.but2.Text = "RESTA";
            this.but2.UseVisualStyleBackColor = false;
            this.but2.Click += new System.EventHandler(this.button2_Click);
            // 
            // but3
            // 
            this.but3.BackColor = System.Drawing.Color.Pink;
            this.but3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.but3.Location = new System.Drawing.Point(445, 183);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(75, 40);
            this.but3.TabIndex = 3;
            this.but3.Text = "RESTO";
            this.but3.UseVisualStyleBackColor = false;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // CER1
            // 
            this.CER1.BackColor = System.Drawing.Color.LightPink;
            this.CER1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CER1.Location = new System.Drawing.Point(382, 341);
            this.CER1.Name = "CER1";
            this.CER1.Size = new System.Drawing.Size(83, 36);
            this.CER1.TabIndex = 4;
            this.CER1.Text = "CERRAR";
            this.CER1.UseVisualStyleBackColor = false;
            this.CER1.Click += new System.EventHandler(this.CER1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(583, 518);
            this.Controls.Add(this.CER1);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.bot1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bot1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button CER1;
    }
}

