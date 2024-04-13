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
    /// Lógica de interacción para ElminarCliente.xaml
    /// </summary>
    public partial class ElminarCliente : Window
    {
        public ElminarCliente()
        {
            InitializeComponent();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            string server = "LAB1504-14\\SQLEXPRESS";
            string database = "neptunoDB";
            string user = "brayan";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("USP_EliminarCliente", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", txtIDCliente.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente elminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
            }
        }
    }
}
