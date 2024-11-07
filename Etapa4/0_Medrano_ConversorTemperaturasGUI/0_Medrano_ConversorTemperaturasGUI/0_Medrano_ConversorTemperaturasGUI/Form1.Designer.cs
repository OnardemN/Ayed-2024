namespace _0_Medrano_ConversorTemperaturasGUI
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
            this.CELCIUS = new System.Windows.Forms.TextBox();
            this.BOTON = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FARENHEIT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KELVIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRADOS CELCIUS:";
            // 
            // CELCIUS
            // 
            this.CELCIUS.Location = new System.Drawing.Point(53, 59);
            this.CELCIUS.Name = "CELCIUS";
            this.CELCIUS.Size = new System.Drawing.Size(100, 20);
            this.CELCIUS.TabIndex = 1;
            this.CELCIUS.TextChanged += new System.EventHandler(this.CELCIUS_TextChanged);
            // 
            // BOTON
            // 
            this.BOTON.Location = new System.Drawing.Point(111, 254);
            this.BOTON.Name = "BOTON";
            this.BOTON.Size = new System.Drawing.Size(75, 23);
            this.BOTON.TabIndex = 2;
            this.BOTON.Text = "CALCULAR";
            this.BOTON.UseVisualStyleBackColor = true;
            this.BOTON.Click += new System.EventHandler(this.BOTON_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FARENHEIT:";
            // 
            // FARENHEIT
            // 
            this.FARENHEIT.AutoSize = true;
            this.FARENHEIT.Location = new System.Drawing.Point(383, 44);
            this.FARENHEIT.Name = "FARENHEIT";
            this.FARENHEIT.Size = new System.Drawing.Size(23, 13);
            this.FARENHEIT.TabIndex = 4;
            this.FARENHEIT.Text = "0°F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "KELVIN:";
            // 
            // KELVIN
            // 
            this.KELVIN.AutoSize = true;
            this.KELVIN.Location = new System.Drawing.Point(386, 146);
            this.KELVIN.Name = "KELVIN";
            this.KELVIN.Size = new System.Drawing.Size(24, 13);
            this.KELVIN.TabIndex = 6;
            this.KELVIN.Text = "0°K";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(575, 313);
            this.Controls.Add(this.KELVIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FARENHEIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BOTON);
            this.Controls.Add(this.CELCIUS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CELCIUS;
        private System.Windows.Forms.Button BOTON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FARENHEIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label KELVIN;
    }
}

