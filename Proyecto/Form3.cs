using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form3 : Form
    {
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Form2 form2 = new Form2();
            form2.Show();
        }

        public Form3()
        {
            InitializeComponent();
        }
        private void buttonActualizarLaContraseña_Click(object sender, EventArgs e)
        {
            
            string nuevaContraseña = textBoxNuevaContraseña.Text;
            string repetirContraseña = textBoxRepetirContraseña.Text;

          
            if (nuevaContraseña != repetirContraseña)
            {
             
                MessageBox.Show("Las contraseñas no coinciden. Inténtelo de nuevo.");
                return;
            }

         
            MessageBox.Show("La contraseña se ha actualizado correctamente.");


        }

    }
}
