using Cassandra;
using hoteleria.Database;
using hoteleria.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoteleria
{
    public partial class Form4 : Form
    {
        Hotel hotelSeleccionado = new Hotel();
        Habitacion habitacionSeleccionada = new Habitacion();
        DateTime FLlegada;
        DateTime FSalida;
        DateTime FHistorial;
        int state = 0;
        double sa = 0;
        public Form4(Hotel hotel, Habitacion habitacion, DateTime entrada, DateTime Salida)
        {
            hotelSeleccionado = hotel;
            habitacionSeleccionada= habitacion;
            FLlegada = entrada;
            FSalida = Salida;
            FHistorial =DateTime.Now;
            InitializeComponent();
            CB_CantidadPersonas.Items.Add("1");
            CB_CantidadPersonas.Items.Add("2");
            CB_CantidadPersonas.Items.Add("3");
            CB_CantidadPersonas.Items.Add("4");
            CB_CantidadPersonas.Items.Add("5");
            TimeSpan diferencia = Salida - entrada;
            int dias = (int)diferencia.TotalDays + 1;
            float total = habitacion.price * dias;
            TB_Total.Text =total.ToString();
            double anticipo = total * 0.2;
            sa = total *0.05;
            TB_Anticipo.Text = anticipo.ToString();
            CB_MetodoPago.Items.Add("Tarjeta de crédito");
            CB_MetodoPago.Items.Add("Tarjeta de débito");
            CB_MetodoPago.Items.Add("Transferencia bancaria");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_CantidadPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_Reservar_Click(object sender, EventArgs e)
        {
            if (CB_MetodoPago.SelectedIndex >= 0 && CB_MetodoPago.SelectedIndex >= 0)
                if (int.Parse(CB_CantidadPersonas.Text) <= habitacionSeleccionada.maxPeople)
                {
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        int num = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[num];
                        Reservacion reservacion = new Reservacion();
                        reservacion.paisRev = hotelSeleccionado.country;
                        reservacion.lastNameRev = TB_Apellidos.Text;
                        reservacion.numRoomRev = habitacionSeleccionada.roomNum;
                        reservacion.cityRev = hotelSeleccionado.city;
                        reservacion.hotelRev = hotelSeleccionado.id.ToString();
                        reservacion.emailCli = selectedRow.Cells["emailcli"].Value.ToString();
                        reservacion.rfcRev = TB_RFC.Text;
                        reservacion.RevNumStatus = false;
                        reservacion.fechaEntrada = new Cassandra.LocalDate(FLlegada.Year, FLlegada.Month, FLlegada.Day);
                        reservacion.metodoPago = CB_MetodoPago.Text;
                        reservacion.fechaSalida = new Cassandra.LocalDate(FSalida.Year, FSalida.Month, FSalida.Day);
                        reservacion.roomTypeRev = habitacionSeleccionada.type;
                        reservacion.amenities = new List<string>();
                        reservacion.amenities = habitacionSeleccionada.amenities;
                        reservacion.AnticipoRev = int.Parse(TB_Anticipo.Text);
                        reservacion.maxPeopleRev = habitacionSeleccionada.maxPeople;
                        reservacion.PeopleInsideREV = int.Parse(CB_CantidadPersonas.Text);
                        reservacion.totalRev = int.Parse(TB_Total.Text);
                        LocalDate fechaActual = new Cassandra.LocalDate(FHistorial.Year, FHistorial.Month, FHistorial.Day);
                        reservacion.userR = Manager.UsuarioIS;
                        Manager db = Manager.getInstance();
                        double tot = reservacion.totalRev + sa;
                        db.InsertarReservacion(reservacion);
                        MessageBox.Show("Se ha reservado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.AgregarHistorial(reservacion.lastNameRev, reservacion.emailCli, reservacion.rfcRev, TB_Nombre.Text,
                            reservacion.cityRev, db.NombreHotel(reservacion.hotelRev), habitacionSeleccionada.level,
                            habitacionSeleccionada.roomNum, reservacion.PeopleInsideREV, reservacion.fechaEntrada,
                            reservacion.fechaSalida, fechaActual, reservacion.RevNumStatus, reservacion.AnticipoRev, reservacion.totalRev, sa, tot);
                        dataGridView1.DataSource = null;
                        this.Refresh();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El RFC A QUE HORA LO PONES", "Piensale tantito mi rey", MessageBoxButtons.OK);
                    }
                }
                else
                {

                    MessageBox.Show("No se ha reservado, meta datos validos >:/", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else MessageBox.Show("Y la de seleccionar las opciones no te la sabes?", ">:(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_RFC_TextChanged(object sender, EventArgs e)
        {
            Manager db= Manager.getInstance();
            List<Cliente> clientes = new List<Cliente>();
            if(TB_RFC.Text != "")
            {
            var where = " WHERE RFC= '" + TB_RFC.Text + "' allow filtering";
            clientes = db.clientes(where);
            dataGridView1.DataSource = clientes;
            try
            {
            if (clientes.Count == 1)
            { 
                TB_Apellidos.Text= clientes[0].LastName;
                TB_Nombre.Text= clientes[0].FirstName;
            }

            }
            catch
            {

            }

            }
        }
    }
}
