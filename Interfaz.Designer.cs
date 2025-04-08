namespace Practica_base_de_datos
{
    partial class Interfaz
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
            this.button1 = new System.Windows.Forms.Button();
            this.Personas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Personas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Personas
            // 
            this.Personas.Location = new System.Drawing.Point(243, 54);
            this.Personas.Name = "Personas";
            this.Personas.Size = new System.Drawing.Size(75, 35);
            this.Personas.TabIndex = 1;
            this.Personas.Text = "Personas";
            this.Personas.UseVisualStyleBackColor = true;
            this.Personas.Click += new System.EventHandler(this.Personas_Click);
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 239);
            this.Controls.Add(this.Personas);
            this.Controls.Add(this.button1);
            this.Name = "Interfaz";
            this.Text = "Interfaz";
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Personas;
    }
}