﻿namespace Proyecto
{
    partial class Form5
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
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtTelefonoNuevo = new System.Windows.Forms.TextBox();
            this.actualizacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nuevo telefono";
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(263, 125);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(181, 20);
            this.txtNombreNuevo.TabIndex = 2;
            // 
            // txtTelefonoNuevo
            // 
            this.txtTelefonoNuevo.Location = new System.Drawing.Point(263, 190);
            this.txtTelefonoNuevo.Name = "txtTelefonoNuevo";
            this.txtTelefonoNuevo.Size = new System.Drawing.Size(181, 20);
            this.txtTelefonoNuevo.TabIndex = 3;
            // 
            // actualizacion
            // 
            this.actualizacion.Location = new System.Drawing.Point(190, 264);
            this.actualizacion.Name = "actualizacion";
            this.actualizacion.Size = new System.Drawing.Size(90, 45);
            this.actualizacion.TabIndex = 4;
            this.actualizacion.Text = "Actualizar";
            this.actualizacion.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.actualizacion);
            this.Controls.Add(this.txtTelefonoNuevo);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtTelefonoNuevo;
        private System.Windows.Forms.Button actualizacion;
    }
}