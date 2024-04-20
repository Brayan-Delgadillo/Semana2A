using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Semana2A
{
    /// <summary>
    /// Lógica de interacción para ModificarCliente.xaml
    /// </summary>
    public partial class ModificarCliente : Window
    {
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            string server = "LAB1504-15\\SQLEXPRESS";
            string database = "neptunoDB";
            string user = "brayandelgadillo";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("USP_ActualizarCliente", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", txtIDCliente.Text);
                    cmd.Parameters.AddWithValue("@NuevoNombreCompañia", txtNombreCompania.Text);
                    cmd.Parameters.AddWithValue("@NuevoNombreContacto", txtNombreContacto.Text);
                    cmd.Parameters.AddWithValue("@NuevoCargoContacto", txtCargoContacto.Text);
                    cmd.Parameters.AddWithValue("@NuevoDireccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@NuevoTelefono", txtTelefono.Text);
                    // Añade más parámetros para los demás campos

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente modificado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message);
            }
        }
    }
}
