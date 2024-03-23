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
    /// Lógica de interacción para Operaciones.xaml
    /// </summary>
    public partial class Operaciones : Window
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            Op_Ingresos op_Ingresos = new Op_Ingresos();
            op_Ingresos.ShowDialog();
        }

        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            Op_Salidas op_Salidas = new Op_Salidas();
            op_Salidas.ShowDialog();
        }
    }
}
