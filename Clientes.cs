using hoteleria;
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
using Cassandra;

namespace Proyecto_AAVD
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            DGV_Clientes.DataSource = Manager.getInstance().get_Clients();
        }

        private void B_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_Modificar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente();
            nuevoCliente.street = TB_Calle.Text;
            //nuevoCliente.number = int.Parse(TB_CodigoPostal.Text);
            nuevoCliente.number = int.Parse(TB_NumeroExterior.Text);
            nuevoCliente.neighborhood = TB_Colonia.Text;
            nuevoCliente.FirstName = TB_Nombre.Text;
            nuevoCliente.LastName = TB_Apellidos.Text;
            nuevoCliente.emailCLI = TB_Correo.Text;
            nuevoCliente.rfc = TB_RFC.Text;
            nuevoCliente.tel1 = TB_Celular.Text;
            nuevoCliente.tel2 = TB_Casa.Text;
            nuevoCliente.reference = TB_Referencia.Text;
            if (RB_Casado.Checked) nuevoCliente.civilStatus = RB_Casado.Text;
            else if (RB_Divorciado.Checked) nuevoCliente.civilStatus = RB_Divorciado.Text;
            else if (RB_Viudo.Checked) nuevoCliente.civilStatus = RB_Viudo.Text;
            else nuevoCliente.civilStatus = RB_Soltero.Text;
            nuevoCliente.birthdateCLI = LocalDate.Parse(DTP_FechaNacimiento.Value.ToString("yyyy-MM-dd"));

            Manager.getInstance().insert_Clients(nuevoCliente);

        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente();
            nuevoCliente.rfc = TB_RFC.Text;
            Manager.getInstance().delete_Clients(nuevoCliente);

        }

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente();
            nuevoCliente.street = TB_Calle.Text;
            //nuevoCliente.number = int.Parse(TB_CodigoPostal.Text);
            nuevoCliente.number = int.Parse(TB_NumeroExterior.Text);
            nuevoCliente.neighborhood = TB_Colonia.Text;
            nuevoCliente.FirstName = TB_Nombre.Text;
            nuevoCliente.LastName = TB_Apellidos.Text;
            nuevoCliente.emailCLI = TB_Correo.Text;
            nuevoCliente.rfc = TB_RFC.Text;
            nuevoCliente.tel1 = TB_Celular.Text;
            nuevoCliente.tel2 = TB_Casa.Text;
            nuevoCliente.reference = TB_Referencia.Text;
            if (RB_Casado.Checked) nuevoCliente.civilStatus = RB_Casado.Text;
            else if (RB_Divorciado.Checked) nuevoCliente.civilStatus = RB_Divorciado.Text;
            else if (RB_Viudo.Checked) nuevoCliente.civilStatus = RB_Viudo.Text;
            else nuevoCliente.civilStatus = RB_Soltero.Text;
            nuevoCliente.birthdateCLI = LocalDate.Parse(DTP_FechaNacimiento.Value.ToString("yyyy-MM-dd"));
            nuevoCliente.userR = Manager.UsuarioIS;
            Manager.getInstance().insert_Clients(nuevoCliente);
        }

        private void DGV_Clientes_SelectionChanged(object sender, EventArgs e)
        {
            TB_Calle.Text = DGV_Clientes.CurrentRow.Cells["street"].Value.ToString();
            TB_RFC.Text = DGV_Clientes.CurrentRow.Cells["rfc"].Value.ToString();
            TB_Colonia.Text = DGV_Clientes.CurrentRow.Cells["neighborhood"].Value.ToString();
            TB_NumeroExterior.Text = DGV_Clientes.CurrentRow.Cells["number"].Value.ToString();
            TB_Nombre.Text = DGV_Clientes.CurrentRow.Cells["FirstName"].Value.ToString();
            TB_Apellidos.Text = DGV_Clientes.CurrentRow.Cells["LastName"].Value.ToString();
            TB_Correo.Text = DGV_Clientes.CurrentRow.Cells["emailCLI"].Value.ToString();
            TB_Celular.Text = DGV_Clientes.CurrentRow.Cells["tel1"].Value.ToString();
            TB_Casa.Text = DGV_Clientes.CurrentRow.Cells["tel2"].Value.ToString();
            TB_Referencia.Text = DGV_Clientes.CurrentRow.Cells["reference"].Value.ToString();
            if (DGV_Clientes.CurrentRow.Cells["civilStatus"].Value.ToString() == RB_Casado.Text)
                RB_Casado.Checked = true;
            else if (DGV_Clientes.CurrentRow.Cells["civilStatus"].Value.ToString() == RB_Divorciado.Text)
                RB_Divorciado.Checked = true;
            else if(DGV_Clientes.CurrentRow.Cells["civilStatus"].Value.ToString() == RB_Viudo.Text)
                RB_Viudo.Checked = true;
            else if(DGV_Clientes.CurrentRow.Cells["civilStatus"].Value.ToString() == RB_Soltero.Text)
                RB_Soltero.Checked = true;
            DTP_FechaNacimiento.Value = DateTime.Parse(DGV_Clientes.CurrentRow.Cells["birthdateCLI"].Value.ToString());
        }

    }
}
