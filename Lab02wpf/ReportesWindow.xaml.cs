using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Lab02wpf
{
    public partial class ReportesWindow : Window
    {
        public class Reporte
        {
            public DateTime Fecha { get; set; }
            public string Placa { get; set; }
            public string Turno { get; set; }
            public string Conductor { get; set; }
            public string Producto { get; set; }
            public double Peso { get; set; }
            public string Transporte { get; set; }
        }

        private List<Reporte> listaReportes;

        public ReportesWindow()
        {
            InitializeComponent();
            CargarDatos();
            dgReportes.ItemsSource = listaReportes;
        }

        private void CargarDatos()
        {
            // Datos simulados (en tu caso deberían venir de BD o archivo)
            listaReportes = new List<Reporte>
            {
                new Reporte { Fecha = DateTime.Now.AddDays(-2), Placa="ABC123", Turno="Mañana", Conductor="Juan Pérez", Producto="Arena", Peso=1000, Transporte="Camión" },
                new Reporte { Fecha = DateTime.Now.AddDays(-1), Placa="XYZ789", Turno="Tarde", Conductor="Luis García", Producto="Cemento", Peso=800, Transporte="Camión" },
                new Reporte { Fecha = DateTime.Now, Placa="DEF456", Turno="Noche", Conductor="Carlos Ruiz", Producto="Piedra", Peso=1200, Transporte="Volquete" }
            };
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            var query = listaReportes.AsEnumerable();

            if (dpFechaInicio.SelectedDate.HasValue)
                query = query.Where(r => r.Fecha >= dpFechaInicio.SelectedDate.Value);

            if (dpFechaFin.SelectedDate.HasValue)
                query = query.Where(r => r.Fecha <= dpFechaFin.SelectedDate.Value);

            if (!string.IsNullOrWhiteSpace(txtPlaca.Text))
                query = query.Where(r => r.Placa.Contains(txtPlaca.Text, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(txtConductor.Text))
                query = query.Where(r => r.Conductor.Contains(txtConductor.Text, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(txtProducto.Text))
                query = query.Where(r => r.Producto.Contains(txtProducto.Text, StringComparison.OrdinalIgnoreCase));

            dgReportes.ItemsSource = query.ToList();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
