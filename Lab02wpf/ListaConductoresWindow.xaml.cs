using System.Windows;

namespace Lab02wpf
{
    public partial class ListaConductoresWindow : Window
    {
        public ListaConductoresWindow()
        {
            InitializeComponent();

            // Simulación de datos
            lstConductores.Items.Add("Juan Pérez - Licencia: A123 - Transporte: TransPeru");
            lstConductores.Items.Add("Carlos Gómez - Licencia: B456 - Transporte: FastCargo");
            lstConductores.Items.Add("Ana Torres - Licencia: C789 - Transporte: LimaTrans");
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
