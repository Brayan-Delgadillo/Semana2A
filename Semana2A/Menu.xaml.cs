using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Operaciones_Click(object sender, RoutedEventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.ShowDialog();
        }

        private void Mantenimiento_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.ShowDialog();
        }

        private void Reportes_Click(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.ShowDialog();
        }

        private void BaseDeDatos_Click(object sender, RoutedEventArgs e)
        {
            BaseDeDatos baseDeDatos = new BaseDeDatos();
            baseDeDatos.ShowDialog();
        }
    }
}
