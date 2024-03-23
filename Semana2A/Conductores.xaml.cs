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
    /// Lógica de interacción para Conductores.xaml
    /// </summary>
    public partial class Conductores : Window
    {
        public Conductores()
        {
            InitializeComponent();
        }

        private void Insertar_Click(object sender, RoutedEventArgs e)
        {
            Conductores_Ins conductores_Ins = new Conductores_Ins();
            conductores_Ins.ShowDialog();
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            Conductores_List conductores_List = new Conductores_List();
            conductores_List.ShowDialog();
        }
    }
}
