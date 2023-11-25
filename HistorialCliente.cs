using hoteleria.Database;
using hoteleria.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hoteleria
{
    public partial class HistorialCliente : Form
    {
        private List<HistClient> currentList;
        public HistorialCliente()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void update_DGV_Historial(string rfc = null)
        {
            if (rfc == null)
            {
                DGV_Historial.DataSource = Manager.getInstance().get_HistClients();

            }
            else 
            { 
                DGV_Historial.DataSource = Manager.getInstance().get_HistClient(rfc);
            }
            currentList = (List<HistClient>)DGV_Historial.DataSource;
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            update_DGV_Historial();
            CB_RFC.Items.Add("Cualquier cliente");
            CB_Año.Items.Add("Cualquier año");
            foreach (Cliente cliente in Manager.getInstance().get_Clients())
            {
                CB_RFC.Items.Add(cliente.rfc);
            }

        }

        private void B_Volver_Click(object sender, EventArgs e)
        {

        }

        private void CB_RFC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_RFC.SelectedIndex == 0)
            {
                update_DGV_Historial();
                CB_Año.Items.Clear();
                CB_Año.Enabled = false;
            }
            else
            {
                CB_Año.Enabled = true;
                string rfc = CB_RFC.Text;
                update_DGV_Historial(rfc);

                CB_Año.Items.Clear();
                CB_Año.Items.Add("Cualquier año");
                foreach (DataGridViewRow row in DGV_Historial.Rows)
                {
                    if (!CB_Año.Items.Contains((DateTime.Parse(row.Cells["FechaReservacionHist"].Value.ToString())).Year.ToString()))
                    {
                        CB_Año.Items.Add((DateTime.Parse(row.Cells["FechaReservacionHist"].Value.ToString())).Year.ToString());
                    }
                }
            }
        }

        private void CB_Año_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Año.SelectedIndex != 0)
            {
                string rfc = CB_RFC.Text;
                int offset = 0;
                update_DGV_Historial(rfc);

                foreach (DataGridViewRow row in DGV_Historial.Rows)
                {
                    var temp = DGV_Historial.Rows[row.Index - offset];
                    if (temp.Cells["FechaReservacionHist"].Value != null && ((DateTime.Parse(temp.Cells["FechaReservacionHist"].Value.ToString())).Year.ToString()) != CB_Año.Text)
                    {
                        currentList.RemoveAt(row.Index - offset);
                        offset++;
                    }
                }
                DGV_Historial.DataSource = null;
                DGV_Historial.DataSource = currentList;
            }
            else
            {
                update_DGV_Historial(CB_RFC.Text);
            }
        }
    }
}
