using hoteleria.Database;
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
    public partial class CancelarReservacion : Form
    {
        public CancelarReservacion()
        {
            InitializeComponent();
            cargartable();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int num = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[num];

                DateTime FLlegada = DateTime.Parse(selectedRow.Cells["fechaEntrada"].Value.ToString());
                TimeSpan checarDias = FLlegada - DateTime.Now;
                if ((int)checarDias.TotalDays > 2)
                {

                    Reservacion reservacion = new Reservacion();

                    reservacion.emailCli = selectedRow.Cells["emailcli"].Value.ToString();
                    reservacion.hotelRev = selectedRow.Cells["hotelRev"].Value.ToString();
                    reservacion.fechaEntrada = new Cassandra.LocalDate(FLlegada.Year, FLlegada.Month, FLlegada.Day);
                    Guid uwu = Guid.Parse(selectedRow.Cells["RevNum"].Value.ToString());
                    reservacion.RevNum = uwu;
                    reservacion.userR = "uwu";
                    Manager db = Manager.getInstance();

                    db.InsertarCancelacion(reservacion);
                    MessageBox.Show("Se ha cancelado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargartable();
                }
                else
                {
                    MessageBox.Show("Ya se te paso la fecha pa cancelar :/", "D:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
        private void cargartable()
        {
            Manager db = Manager.getInstance();
            List<Reservacion> lista = db.Reservaciones();
            List<Reservacion> copia = lista.ToList();
            List<Cancelacion> lista1 = db.SeleccionarCancelaciones();
            foreach (Reservacion reservacion in lista)
            {
                foreach (Cancelacion cancelacion in lista1)
                {
                    if (reservacion.RevNum == cancelacion.RevCodigoC)
                    {
                        copia.Remove(reservacion);
                    }
                }
            }
            dataGridView1.DataSource = copia;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
