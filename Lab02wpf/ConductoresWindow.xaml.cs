using System.Windows;

namespace Lab02wpf
{
    public partial class ConductoresWindow : Window
    {
        public ConductoresWindow()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            string datos = $"Conductor: {txtNombreConductor.Text}\n" +
                           $"Licencia: {txtLicencia.Text}\n" +
                           $"Transporte: {txtTransporte.Text}";
            MessageBox.Show("Conductor registrado:\n\n" + datos, "Registro");
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
