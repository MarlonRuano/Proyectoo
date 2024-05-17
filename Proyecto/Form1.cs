using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellidos.Text) ||
                string.IsNullOrEmpty(Correo.Text) || string.IsNullOrEmpty(Contraseña.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de correo electrónico
            if (!IsValidEmail(Correo.Text))
            {
                MessageBox.Show("Formato de correo electrónico incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registro de usuario en la base de datos
            try
            {
                InsertarUsuario(Nombre.Text, Apellidos.Text, Correo.Text, Contraseña.Text);
                MessageBox.Show("Usuario registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarUsuario(string nombre, string apellido, string correo, string contraseña)
        {
            // Configuración de la cadena de conexión
            string connectionString = @"Data Source=LAPTOP-6DJSP6KC\SQLEXPRESS;Initial Catalog=ProyectoP1;Integrated Security=True;";

            // Insertar usuario en la base de datos
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuarios1 (Nombre, Apellido, Correo, Contraseña) VALUES (@Nombre, @Apellido, @Correo, @Contraseña)";
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    
    }
}
