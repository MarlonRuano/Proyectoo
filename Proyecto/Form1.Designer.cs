namespace Proyecto
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
            this.n1 = new System.Windows.Forms.TextBox();
            this.a1 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Enabled = false;
            this.n1.Location = new System.Drawing.Point(103, 91);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(100, 22);
            this.n1.TabIndex = 0;
            this.n1.Text = "Nombre:";
            // 
            // a1
            // 
            this.a1.Enabled = false;
            this.a1.Location = new System.Drawing.Point(103, 137);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(100, 22);
            this.a1.TabIndex = 1;
            this.a1.Text = "Apellido:";
            // 
            // c1
            // 
            this.c1.Enabled = false;
            this.c1.Location = new System.Drawing.Point(103, 186);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(121, 22);
            this.c1.TabIndex = 2;
            this.c1.Text = "Correo electronico:";
            // 
            // c2
            // 
            this.c2.Enabled = false;
            this.c2.Location = new System.Drawing.Point(103, 229);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(100, 22);
            this.c2.TabIndex = 3;
            this.c2.Text = "Contraseña:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(276, 91);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 22);
            this.Nombre.TabIndex = 4;
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(276, 137);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(100, 22);
            this.Apellidos.TabIndex = 5;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(276, 186);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(100, 22);
            this.Correo.TabIndex = 6;
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(276, 229);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(100, 22);
            this.Contraseña.TabIndex = 7;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(485, 170);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 23);
            this.Registrar.TabIndex = 8;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox a1;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.TextBox c2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Button Registrar;
    }
}

