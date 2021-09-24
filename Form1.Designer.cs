
namespace ProgramaA_Lectura
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
            this.Btn_Generar = new System.Windows.Forms.Button();
            this.Btn_Leer = new System.Windows.Forms.Button();
            this.Txt_Archivo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Generar
            // 
            this.Btn_Generar.Location = new System.Drawing.Point(881, 1);
            this.Btn_Generar.Name = "Btn_Generar";
            this.Btn_Generar.Size = new System.Drawing.Size(120, 43);
            this.Btn_Generar.TabIndex = 5;
            this.Btn_Generar.Text = "Generar archivo";
            this.Btn_Generar.UseVisualStyleBackColor = true;
            this.Btn_Generar.Click += new System.EventHandler(this.Btn_Generar_Click);
            // 
            // Btn_Leer
            // 
            this.Btn_Leer.Location = new System.Drawing.Point(12, 1);
            this.Btn_Leer.Name = "Btn_Leer";
            this.Btn_Leer.Size = new System.Drawing.Size(120, 43);
            this.Btn_Leer.TabIndex = 6;
            this.Btn_Leer.Text = "Leer Archivo";
            this.Btn_Leer.UseVisualStyleBackColor = true;
            this.Btn_Leer.Click += new System.EventHandler(this.Btn_Leer_Click_1);
            // 
            // Txt_Archivo
            // 
            this.Txt_Archivo.Location = new System.Drawing.Point(12, 50);
            this.Txt_Archivo.Multiline = true;
            this.Txt_Archivo.Name = "Txt_Archivo";
            this.Txt_Archivo.Size = new System.Drawing.Size(989, 171);
            this.Txt_Archivo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 230);
            this.Controls.Add(this.Txt_Archivo);
            this.Controls.Add(this.Btn_Leer);
            this.Controls.Add(this.Btn_Generar);
            this.Name = "Form1";
            this.Text = "Programa A - Lectura de Archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Generar;
        private System.Windows.Forms.Button Btn_Leer;
        private System.Windows.Forms.TextBox Txt_Archivo;
    }
}

