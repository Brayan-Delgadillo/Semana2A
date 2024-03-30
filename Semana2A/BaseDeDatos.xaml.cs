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
    /// Lógica de interacción para BaseDeDatos.xaml
    /// </summary>
    public partial class BaseDeDatos : Window
    {
        public BaseDeDatos()
        {
            InitializeComponent();
        }

        private void dataTable_Click(object sender, RoutedEventArgs e)
        {
            string server = "LAB1504-16\\TECSUP";
            string database = "prueba";
            string user = "BrayanDBA";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dataTable);

                connection.Close();

                brayanTable.ItemsSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dataReader_Click(object sender, RoutedEventArgs e)
        {
            string server = "LAB1504-16\\TECSUP";
            string database = "prueba";
            string user = "BrayanDBA";
            string password = "123456";
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            List<Student> students = new List<Student>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int IdStudent = reader.GetInt32("studentId");
                    string FirstName = reader.GetString("firstName");
                    string LastName = reader.GetString("lastName");

                    students.Add(new Student(IdStudent, FirstName, LastName));
                }
                connection.Close();
                brayanTable.ItemsSource = students;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            
    }
}
