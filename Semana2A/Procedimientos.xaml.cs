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
    /// Lógica de interacción para Procedimientos.xaml
    /// </summary>
    public partial class Procedimientos : Window
    {
        public Procedimientos()
        {
            InitializeComponent();
        }

        private void productos_Click(object sender, RoutedEventArgs e)
        {
            string server = "LAB1504-14\\SQLEXPRESS";
            string database = "neptunoDB";
            string user = "brayan";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            List<Producto> productos = new List<Producto>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("USP_ListarProductos", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idproducto = reader.GetInt32("idproducto");
                    string nombreProducto = reader.GetString("nombreProducto");
                    string cantidadPorUnidad = reader.GetString("cantidadPorUnidad");
                    decimal precioUnidad = reader.GetDecimal("precioUnidad");
                    //string categoriaProducto = reader.GetString("categoriaProducto");

                    productos.Add(new Producto(idproducto, nombreProducto, cantidadPorUnidad, precioUnidad, "NA"));
                }
                connection.Close();
                brayanTable.ItemsSource = productos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void categorias_Click(object sender, RoutedEventArgs e)
        {
            string server = "LAB1504-14\\SQLEXPRESS";
            string database = "neptunoDB";
            string user = "brayan";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            List<Categoria> categorias = new List<Categoria>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("USP_ListarCategorias", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idcategoria = reader.GetInt32("idcategoria");
                    string nombrecategoria = reader.GetString("nombrecategoria");
                    string descripcion = reader.GetString("descripcion");
                    string codCategoria = reader.GetString("codCategoria");

                    categorias.Add(new Categoria(idcategoria, nombrecategoria, descripcion, codCategoria));
                }
                connection.Close();
                brayanTable.ItemsSource = categorias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void proveedores_Click(object sender, RoutedEventArgs e)
        {
            string server = "LAB1504-14\\SQLEXPRESS";
            string database = "neptunoDB";
            string user = "brayan";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            List<Proveedor> proveedores = new List<Proveedor>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("USP_ListarProveedores", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int idProveedor = reader.GetInt32("idProveedor");
                    string nombreCompañia = reader.GetString("nombreCompañia");
                    string nombreContacto = reader.GetString("nombreContacto");
                    string cargocontacto = reader.GetString("cargocontacto");
                    string direccion = reader.GetString("direccion");

                    proveedores.Add(new Proveedor(idProveedor, nombreCompañia, nombreContacto, cargocontacto, direccion));
                }
                connection.Close();
                brayanTable.ItemsSource = proveedores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
