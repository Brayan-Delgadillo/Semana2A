using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : Window
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void clientes_Click(object sender, RoutedEventArgs e)
        {
            string server = "LAB1504-15\\SQLEXPRESS";
            string database = "neptunoDB";
            string user = "brayandelgadillo";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            List<Cliente> clientes = new List<Cliente>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("USP_ListarClientes", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string idCliente = reader.GetString("idCliente");
                    string nombreCompañia = reader.GetString("NombreCompañia");
                    string nombreContacto = reader.GetString("NombreContacto");
                    string cargoContacto = reader.GetString("CargoContacto");
                    string direccion = reader.GetString("Direccion");
                    string telefono = reader.GetString("Telefono");
                    bool activo = reader.GetBoolean("Activo");

                    clientes.Add(new Cliente(idCliente, nombreCompañia, nombreContacto, cargoContacto, direccion, telefono, activo));
                }
                connection.Close();
                brayanTable.ItemsSource = clientes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void insertar_Click(object sender, RoutedEventArgs e)
        {
            InsertarCliente insertarCliente = new InsertarCliente();
            insertarCliente.ShowDialog();
        }

        private void modificar_Click(object sender, RoutedEventArgs e)
        {
            ModificarCliente modificarCliente = new ModificarCliente();
            modificarCliente.ShowDialog();
        }

        private void eliminar_Click(object sender, RoutedEventArgs e)
        {
            ElminarCliente elminarCliente = new ElminarCliente();
            elminarCliente.ShowDialog();
        }
    }
}
