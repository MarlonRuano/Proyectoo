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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void btnactualizacion_Click(object sender, EventArgs e)
        {
            // Obtenga los nuevos datos del usuario
            string nombreNuevo = txtNombreNuevo.Text;
            string telefonoNuevo = txtTelefonoNuevo.Text;

            // Actualice la información del usuario en la base de datos o en el sistema (reemplace con su código real)
            // ...

            // Muestre un mensaje de éxito
            MessageBox.Show("¡Usuario actualizado con éxito!");
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }


    }
}
