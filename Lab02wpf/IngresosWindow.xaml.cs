using System.Windows;

namespace Lab02wpf
{
    public partial class IngresosWindow : Window
    {
        public IngresosWindow()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Simulamos guardar mostrando los valores
            string datos = $"Documento: {txtTipoDocumento.Text} - {txtNumeroDocumento.Text}\n" +
                           $"Placa: {txtPlaca.Text}\n" +
                           $"Turno: {txtTurno.Text}\n" +
                           $"Conductor: {txtConductor.Text}\n" +
                           $"Cliente: {txtCliente.Text}\n" +
                           $"Fecha y Hora: {txtFechaHora.Text}\n" +
                           $"Peso: {txtPesoIngreso.Text}";

            MessageBox.Show("Datos guardados:\n\n" + datos, "Registro de Ingresos");
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // cierra esta ventana y regresa al menú
        }
    }
}
