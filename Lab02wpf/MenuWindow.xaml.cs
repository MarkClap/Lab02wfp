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

namespace Lab02wpf
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void BtnOperaciones_Click(object sender, RoutedEventArgs e)
        {
            IngresosWindow ingresos = new IngresosWindow();
            ingresos.ShowDialog();
        }

        private void BtnMantenimientos_Click(object sender, RoutedEventArgs e)
        {
            ConductoresWindow cond = new ConductoresWindow();
            cond.ShowDialog();

            ListaConductoresWindow lista = new ListaConductoresWindow();
            lista.ShowDialog();
        }

        private void BtnReportes_Click(object sender, RoutedEventArgs e)
        {
            ReportesWindow rep = new ReportesWindow();
            rep.ShowDialog();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

}
