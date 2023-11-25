using Cassandra;
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
    public partial class ReporteVentas : Form
    {

        private List<DatosVentas> currentList;
        public ReporteVentas()
        {
            InitializeComponent();
        }

        private void update_DGV_Reporte(string pais = null, string año = null, string ciudad = null, string hotel = null)
        {
            DGV_Reporte.DataSource = Manager.getInstance().get_ReporteVentas();
            List<DatosVentas> hoteles = new List<DatosVentas>();
            List<string> hotelesName = new List<string>();
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (row.Cells["hotelRev"].Value != null && !hotelesName.Contains(row.Cells["hotelRev"].Value.ToString()))
                {
                    var data = new DatosVentas();
                    data.Hotel = row.Cells["hotelRev"].Value.ToString();
                    data.Pais = row.Cells["paisRev"].Value.ToString();
                    data.Fecha = DateTime.Parse(row.Cells["dateTimeR"].Value.ToString());
                    data.Año_Mes = data.Fecha.ToString("MM-yyyy");
                    data.Ciudad = row.Cells["cityRev"].Value.ToString();
                    hoteles.Add(data);
                    hotelesName.Add(row.Cells["hotelRev"].Value.ToString());
                }
            }
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (row.Cells["hotelRev"].Value != null && row.Cells["hotelRev"].Value.ToString() != null)
                {
                    foreach (DatosVentas h in hoteles)
                    {
                        if (h.Hotel == row.Cells["hotelRev"].Value.ToString())
                        {
                            var index = hoteles.IndexOf(h);
                            hoteles[index].Total_Hospedaje += float.Parse(row.Cells["AnticipoRev"].Value.ToString());
                        }
                    }
                    currentList = hoteles;
                }
            }
            foreach (DatosVentas h in hoteles)
            {
                var index = hoteles.IndexOf(h);
                hoteles[index].init_Price();
            }

            DGV_Reporte.DataSource = null;
            DGV_Reporte.DataSource = currentList;

            if (pais != null)
            {
                int offset = 0;

                foreach (DataGridViewRow row in DGV_Reporte.Rows)
                {
                    var temp = DGV_Reporte.Rows[row.Index - offset];
                    if (temp.Cells["Pais"].Value != null && temp.Cells["Pais"].Value.ToString() != CB_Pais.Text)
                    {
                        currentList.RemoveAt(row.Index - offset);
                        offset++;
                    }
                }
                DGV_Reporte.DataSource = null;
                DGV_Reporte.DataSource = currentList;
            }
            if (año != null)
            {
                int offset = 0;

                foreach (DataGridViewRow row in DGV_Reporte.Rows)
                {
                    var temp = DGV_Reporte.Rows[row.Index - offset];
                    if (temp.Cells["Año_Mes"].Value != null && DateTime.Parse(temp.Cells["Año_Mes"].Value.ToString()).Year.ToString() != CB_Año.Text)
                    {
                        currentList.RemoveAt(row.Index - offset);
                        offset++;
                    }
                }
                DGV_Reporte.DataSource = null;
                DGV_Reporte.DataSource = currentList;
            }
            if (ciudad != null)
            {
                int offset = 0;

                foreach (DataGridViewRow row in DGV_Reporte.Rows)
                {
                    var temp = DGV_Reporte.Rows[row.Index - offset];
                    if (temp.Cells["Ciudad"].Value != null && temp.Cells["Ciudad"].Value.ToString() != CB_Ciudad.Text)
                    {
                        currentList.RemoveAt(row.Index - offset);
                        offset++;
                    }
                }
                DGV_Reporte.DataSource = null;
                DGV_Reporte.DataSource = currentList;
            }
            if (hotel != null)
            {
                int offset = 0;

                foreach (DataGridViewRow row in DGV_Reporte.Rows)
                {
                    var temp = DGV_Reporte.Rows[row.Index - offset];
                    if (temp.Cells["Hotel"].Value != null && temp.Cells["Hotel"].Value.ToString() != CB_Hotel.Text)
                    {
                        currentList.RemoveAt(row.Index - offset);
                        offset++;
                    }
                }
                DGV_Reporte.DataSource = null;
                DGV_Reporte.DataSource = currentList;
            }
        }
        private void ReporteVentas_Load(object sender, EventArgs e)
        {
            update_DGV_Reporte();
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Pais.Items.Contains(row.Cells["Pais"].Value.ToString()))
                {
                    CB_Pais.Items.Add(row.Cells["Pais"].Value.ToString());
                }
            }
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Año.Items.Contains((DateTime.Parse(row.Cells["Año_Mes"].Value.ToString())).Year.ToString()))
                {
                    CB_Año.Items.Add((DateTime.Parse(row.Cells["Año_Mes"].Value.ToString())).Year.ToString());
                }
            }
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Ciudad.Items.Contains(row.Cells["Ciudad"].Value.ToString()))
                {
                    CB_Ciudad.Items.Add(row.Cells["Ciudad"].Value.ToString());
                }
            }
            CB_Hotel.Items.Add("Cualquier hotel");
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Hotel.Items.Contains(row.Cells["Hotel"].Value.ToString()))
                {
                    CB_Hotel.Items.Add(row.Cells["Hotel"].Value.ToString());
                }
            }
            CB_Pais.SelectedIndex = 0;
            CB_Año.SelectedIndex = 0;
            CB_Ciudad.SelectedIndex = 0;
            CB_Hotel.SelectedIndex = 0;
        }

        private void B_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CB_Pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_DGV_Reporte(CB_Pais.Text);
            CB_Año.Items.Clear();
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Año.Items.Contains((DateTime.Parse(row.Cells["Año_Mes"].Value.ToString())).Year.ToString()))
                {
                    CB_Año.Items.Add((DateTime.Parse(row.Cells["Año_Mes"].Value.ToString())).Year.ToString());
                }
            }
            CB_Ciudad.Items.Clear();
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Ciudad.Items.Contains(row.Cells["Ciudad"].Value.ToString()))
                {
                    CB_Ciudad.Items.Add(row.Cells["Ciudad"].Value.ToString());
                }
            }
            CB_Hotel.Items.Clear();
            CB_Hotel.Items.Add("Cualquier hotel");
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Hotel.Items.Contains(row.Cells["Hotel"].Value.ToString()))
                {
                    CB_Hotel.Items.Add(row.Cells["Hotel"].Value.ToString());
                }
            }
            CB_Año.SelectedIndex = 0;
            CB_Ciudad.SelectedIndex = 0;
            CB_Hotel.SelectedIndex = 0;
        }

        private void CB_Año_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_DGV_Reporte(CB_Pais.Text, CB_Año.Text);
            CB_Ciudad.Items.Clear();
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Ciudad.Items.Contains(row.Cells["Ciudad"].Value.ToString()))
                {
                    CB_Ciudad.Items.Add(row.Cells["Ciudad"].Value.ToString());
                }
            }
            CB_Hotel.Items.Clear();
            CB_Hotel.Items.Add("Cualquier hotel");
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Hotel.Items.Contains(row.Cells["Hotel"].Value.ToString()))
                {
                    CB_Hotel.Items.Add(row.Cells["Hotel"].Value.ToString());
                }
            }
            CB_Ciudad.SelectedIndex = 0;
            CB_Hotel.SelectedIndex = 0;
        }

        private void CB_Ciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_DGV_Reporte(CB_Pais.Text, CB_Año.Text, CB_Ciudad.Text);
            CB_Hotel.Items.Clear();
            CB_Hotel.Items.Add("Cualquier hotel");
            foreach (DataGridViewRow row in DGV_Reporte.Rows)
            {
                if (!CB_Hotel.Items.Contains(row.Cells["Hotel"].Value.ToString()))
                {
                    CB_Hotel.Items.Add(row.Cells["Hotel"].Value.ToString());
                }
            }
            CB_Hotel.SelectedIndex = 0;
        }

        private void CB_Hotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Hotel.SelectedIndex == 0)
            {
                update_DGV_Reporte(CB_Pais.Text, CB_Año.Text, CB_Ciudad.Text);
            }
            else
            {
                update_DGV_Reporte(CB_Pais.Text, CB_Año.Text, CB_Ciudad.Text, CB_Hotel.Text);
            }
        }
    }
}
