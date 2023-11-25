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
    public partial class Form3 : Form
    {
        Hotel hotelSeleccionado = new Hotel();
        DateTime Fllegada;
        DateTime FSalida;
        public Form3(Hotel hotel, DateTime FechaLlegada, DateTime FechaSalida)
        {
            hotelSeleccionado= hotel;
            Fllegada = FechaLlegada;
            FSalida = FechaSalida;
            InitializeComponent();
            Manager db=Manager.getInstance();
            var where = " where cityRev= '" + hotel.city +
                "' AND hotelRev='" + hotel.id + "' allow filtering";
            List<Reservacion> habitacionesReservadas=db.habitacionesReservadas(where);
            List<Reservacion> copia = habitacionesReservadas.ToList();
            
            foreach(Reservacion reservacion in habitacionesReservadas)
            {
                if (!ChecarFechas(reservacion.FechaEntrada(), reservacion.FechaSalida(), FechaLlegada, FechaSalida))
                {

                    copia.Remove(reservacion);
                }
            }
            var otroWhere = " AND hotel= '" + hotel.id + "' allow filtering";
            List<Habitacion> habitaciones = db.habitaciones(otroWhere);
            List<Habitacion>copia1 = habitaciones.ToList();
            
            foreach(Habitacion habitacion in habitaciones)
            {
                foreach(Reservacion reservacion in copia)
                {

                    if (habitacion.roomNum == reservacion.numRoomRev)
                        copia1.Remove(habitacion);
                }
            }
            dataGridView1.DataSource = copia1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int num = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[num];
                var where = " and hotel= '" + selectedRow.Cells["hotel"].Value + "' and roomNum= " + selectedRow.Cells["roomNum"].Value + " allow filtering";
                Manager db = Manager.getInstance();
                List<Habitacion> lista = db.habitaciones(where);
                Habitacion habitacion = new Habitacion();
                habitacion = lista[0];
                if (lista.Count == 1)
                {
                    Form4 form = new Form4(hotelSeleccionado, habitacion, Fllegada, FSalida);

                    form.FormClosed += (s, args) => this.Close();
                    form.ShowDialog();
                }

            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool ChecarFechas(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            return start1 <= end2 && end1 >= start2; //true si SI topan -false si NO topan
        }
    }
}
