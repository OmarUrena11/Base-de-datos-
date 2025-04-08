namespace Practica_base_de_datos
{
    partial class Personas
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
            this.gvPersonas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPersonas
            // 
            this.gvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPersonas.Location = new System.Drawing.Point(108, 147);
            this.gvPersonas.Name = "gvPersonas";
            this.gvPersonas.Size = new System.Drawing.Size(445, 189);
            this.gvPersonas.TabIndex = 0;
            this.gvPersonas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvPersonas_CellMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(397, 94);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(100, 20);
            this.tbCiudad.TabIndex = 10;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(271, 94);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(100, 20);
            this.tbApellidos.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(135, 94);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.gvPersonas);
            this.Name = "Personas";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.Personas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombre;
    }
}