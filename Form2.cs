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
using hoteleria.Database;
namespace hoteleria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            Manager db = Manager.getInstance();
            List<Hotel> lista = db.hoteles(); 
            dataGridView1.DataSource= lista;
            List<string> paises = new List<string>();
            List<string> estados = new List<string>();
            List<string> ciudades = new List<string>();
            HashSet<string> paisUnico = new HashSet<string>();
            HashSet<string> estadoUnico = new HashSet<string>();
            HashSet<string> ciudadUnico = new HashSet<string>();
            foreach(Hotel hotel in lista)
            {
                if (!paisUnico.Contains(hotel.country))
                {
                    paisUnico.Add(hotel.country);
                    paises.Add(hotel.country);
                    
                }
                if (!estadoUnico.Contains(hotel.state))
                {
                    estadoUnico.Add(hotel.state);
                    estados.Add(hotel.state);
                }
                if (!ciudadUnico.Contains(hotel.city))
                {
                    ciudadUnico.Add(hotel.city);
                    ciudades.Add(hotel.city);
                }



            }
            CB_País.DataSource= paises;
            CB_Ciudad.DataSource= ciudades;
            CB_Estado.DataSource= estados;  
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int num = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[num];
                var where = " where city= '" + selectedRow.Cells["city"].Value + "' and nameHotel= '" + selectedRow.Cells["nameHotel"].Value + "' allow filtering";
                Manager db = Manager.getInstance();
                List<Hotel> lista = db.hoteles(where);
                Hotel hotel = new Hotel();
                hotel = lista[0];
                DateTime fechaActual = DateTime.Today;
                DateTime fechaEntrada = DTP_FechaEntrada.Value;
                DateTime fechaSalida = dateTimePicker1.Value;

                TimeSpan DiferenciaEntrada = fechaEntrada - fechaActual;
                TimeSpan DiferenciaSalida = fechaSalida - fechaEntrada;
                //Para que la entrada no sea antes que la fecha actual
                float duracionEnDiasEntrada = (float)DiferenciaEntrada.TotalHours;
                //Para que la salida no sea antes de la fecha de entrada
                float duracionEnDiasSalida = (float)DiferenciaSalida.TotalHours;

                if (duracionEnDiasEntrada >= 0)
                {
                    if (duracionEnDiasSalida >= 1)
                    {
                        if (lista.Count == 1)
                        {
                            Form3 form = new Form3(hotel, DTP_FechaEntrada.Value, dateTimePicker1.Value);
                            form.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La reservación debe ser minimo un día", "Piensale tantito mi rey", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("La fecha ya pasó maik", "Piensale tantito mi rey", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_País_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var where = " where country= '" + CB_País.Text + "' allow filtering";
            Manager db = Manager.getInstance();
            List<Hotel> lista = db.hoteles(where);
            dataGridView1.DataSource = lista;

            List<string> estados = new List<string>();
            List<string> ciudades = new List<string>();
            HashSet<string> estadoUnico = new HashSet<string>();
            HashSet<string> ciudadUnico = new HashSet<string>();
            foreach (Hotel hotel in lista)
            {
                
                if (!estadoUnico.Contains(hotel.state))
                {
                    estadoUnico.Add(hotel.state);
                    estados.Add(hotel.state);
                }
                if (!ciudadUnico.Contains(hotel.city))
                {
                    ciudadUnico.Add(hotel.city);
                    ciudades.Add(hotel.city);
                }

            }
            CB_Ciudad.DataSource = ciudades;
            CB_Estado.DataSource = estados;

        }

        private void CB_Estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var where = " where country= '" + CB_País.Text + "' and state='"+CB_Estado.Text+"' allow filtering";
            Manager db = Manager.getInstance();
            List<Hotel> lista = db.hoteles(where);
            dataGridView1.DataSource = lista;
            List<string> ciudades = new List<string>();
            HashSet<string> ciudadUnico = new HashSet<string>();
            foreach (Hotel hotel in lista)
            {
                if (!ciudadUnico.Contains(hotel.city))
                {
                    ciudadUnico.Add(hotel.city);
                    ciudades.Add(hotel.city);
                }

            }
            CB_Ciudad.DataSource = ciudades;
        }

        private void CB_Ciudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var where = " where country= '" + CB_País.Text + "' and state='" + CB_Estado.Text +"' and city='"+CB_Ciudad.Text+ "' allow filtering";
            Manager db = Manager.getInstance();
            List<Hotel> lista = db.hoteles(where);
            dataGridView1.DataSource = lista;
        }
    }
}
