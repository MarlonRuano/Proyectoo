namespace Proyecto
{
    partial class Form3
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
            this.textBoxNuevaContraseña = new System.Windows.Forms.TextBox();
            this.textBoxRepetirContraseña = new System.Windows.Forms.TextBox();
            this.ActualizarLaContraseña = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca su nueva contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repita la contraseña:";
            // 
            // textBoxNuevaContraseña
            // 
            this.textBoxNuevaContraseña.Location = new System.Drawing.Point(265, 110);
            this.textBoxNuevaContraseña.Name = "textBoxNuevaContraseña";
            this.textBoxNuevaContraseña.Size = new System.Drawing.Size(126, 20);
            this.textBoxNuevaContraseña.TabIndex = 2;
            // 
            // textBoxRepetirContraseña
            // 
            this.textBoxRepetirContraseña.Location = new System.Drawing.Point(265, 171);
            this.textBoxRepetirContraseña.Name = "textBoxRepetirContraseña";
            this.textBoxRepetirContraseña.Size = new System.Drawing.Size(100, 20);
            this.textBoxRepetirContraseña.TabIndex = 3;
            // 
            // ActualizarLaContraseña
            // 
            this.ActualizarLaContraseña.Location = new System.Drawing.Point(246, 252);
            this.ActualizarLaContraseña.Name = "ActualizarLaContraseña";
            this.ActualizarLaContraseña.Size = new System.Drawing.Size(100, 63);
            this.ActualizarLaContraseña.TabIndex = 4;
            this.ActualizarLaContraseña.Text = "Actualizar Contraseña";
            this.ActualizarLaContraseña.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(372, 264);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(106, 50);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.ActualizarLaContraseña);
            this.Controls.Add(this.textBoxRepetirContraseña);
            this.Controls.Add(this.textBoxNuevaContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNuevaContraseña;
        private System.Windows.Forms.TextBox textBoxRepetirContraseña;
        private System.Windows.Forms.Button ActualizarLaContraseña;
        private System.Windows.Forms.Button Cancelar;
    }
}