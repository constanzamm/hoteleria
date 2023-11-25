using hoteleria;
using hoteleria.Database;
using Proyecto_AAVD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoteleria
{
    public partial class Home : Form
    {

        public bool endApp = true;
        public Home()
        {
            InitializeComponent();
        }


        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (endApp)
            {
                Application.Exit();
            }
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que quiere salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
                Application.Exit();
        }

        private void B_Hoteles_Click(object sender, EventArgs e)
        {
            Hoteles hoteles = new Hoteles();
            hoteles.ShowDialog();
        }

        private void B_Usuarios_Click(object sender, EventArgs e)
        {
            Gestion_Usuario gestion_Usuario = new Gestion_Usuario();
            gestion_Usuario.ShowDialog();
        }

        private void B_Clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ShowDialog();
        }

        private void B_Reservaciones_Click(object sender, EventArgs e)
        {
            Form2 reservaciones = new Form2();
            reservaciones.ShowDialog();
        }

        private void B_Reportes_Click(object sender, EventArgs e)
        {
            ReporteVentas reporteVentas = new ReporteVentas();
            reporteVentas.ShowDialog();
        }

        private void B_ReportesOcupacion_Click(object sender, EventArgs e)
        {
            HistorialCliente historialCliente = new HistorialCliente();
            historialCliente.ShowDialog();
        }

        private void BCheIn_Click(object sender, EventArgs e)
        {

            CheckIn checkinconfir = new CheckIn();
            checkinconfir.ShowDialog();

        }

        private void B_CancelarReservaciones_Click(object sender, EventArgs e)
        {
            CancelarReservacion cancelarReservacion = new CancelarReservacion();
            cancelarReservacion.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

            if (Manager.rehabilitado == true)
            {
                Cambiar_Contraseña cambiar_Contraseña = new Cambiar_Contraseña();
                cambiar_Contraseña.ShowDialog();
            }
        }
    }
}
