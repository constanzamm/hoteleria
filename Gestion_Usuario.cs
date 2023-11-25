using Cassandra.Data.Linq;
using hoteleria.Database;
using hoteleria.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace hoteleria
{
    public partial class Gestion_Usuario : Form
    {
        private Manager _instanceManager;
        private bool passChanged = true;

        public Gestion_Usuario()
        {
            InitializeComponent();
            _instanceManager = Manager.getInstance();
            passChanged = false;
        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
            string email = T_email.Text;
            string contra = T_pass.Text;
            string rfc = T_rfc.Text;
            string apellido = T_Apellido.Text;
            string nombre = T_name.Text;
            string calle = T_calle.Text;
            string colonia = T_Colonia.Text;
            string SNum = T_numero.Text;
            int numero = int.Parse(SNum);



            string tel = T_Tel.Text;
            string telCasa = T_TelCasa.Text;

            bool NewPassOK = false;
            string nueva = "";
            string actual = "";
            string contraAnt = "";
            string contraAnt2 = "";
            //List<string> telefonos = AgregarStringsALista(tel, telCasa );

            List<string> contact = new List<string> { tel, telCasa };

            // Convierte la lista a un arreglo antes de pasarlo a la consulta
            //string[] contactArray = contact.ToArray();

            string tipo = null;

            if (RB_Admin.Checked)
            {
                tipo = "1";
            }
            if (RB_Operador.Checked)
            {
                tipo = "0";
            }

            DTP_FechaNacimiento.Format = DateTimePickerFormat.Custom;
            DTP_FechaNacimiento.CustomFormat = "yyyy-MM-dd";
            string fechaNacimiento = DTP_FechaNacimiento.Text.ToString();



            if (passChanged == true)
            {
                nueva = T_pass.Text;

                actual = DGV_Usuarios.CurrentRow.Cells["currentps"].Value.ToString();
                contraAnt = "";
                contraAnt2 = "";


                try
                {
                    if (DGV_Usuarios.SelectedRows[0].Cells["past"].Value != null)
                    {
                        contraAnt = DGV_Usuarios.SelectedRows[0].Cells["past"].Value.ToString();
                    }
                    if (DGV_Usuarios.SelectedRows[0].Cells["past2"].Value != null)
                    {
                        contraAnt2 = DGV_Usuarios.SelectedRows[0].Cells["past2"].Value.ToString();
                    }

                    if (nueva != actual && nueva != contraAnt && nueva != contraAnt2)
                    {
                        NewPassOK = true;


                    }
                    else
                    {
                        NewPassOK = false;
                    }

                    passChanged = false;

                }
                catch
                {

                    MessageBox.Show("Oh no! \n Error", "Okn't :(", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (email != "" && contra != "" && rfc != "" && apellido != "" && nombre != "" && calle != "" && colonia != "" && tel != "" && telCasa != "" && NewPassOK == true && (RB_Admin.Checked || RB_Operador.Checked))
                {
                    _instanceManager.CrearUsuario(email, rfc, apellido, nombre, tipo, fechaNacimiento, calle, colonia, numero, tel, telCasa, Manager.UsuarioIS, nueva, actual, contraAnt, null);
                    MessageBox.Show("Usuario modificado correctamente!", "Ok! :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_Usuarios.DataSource = _instanceManager.SelectTodosUsuarios();
                }
                else
                {
                    MessageBox.Show("Oh no! \nParece que no llenaste todos los datos o la contraseña que intentas registrar es igual a las ultimas 3 que usaste", "Okn't :(", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }

            if (email != "" && contra != "" && rfc != "" && apellido != "" && nombre != "" && calle != "" && colonia != "" && tel != "" && telCasa != "" && (RB_Admin.Checked || RB_Operador.Checked))
            {
                _instanceManager.CrearUsuario(email, rfc, apellido, nombre, tipo, fechaNacimiento, calle, colonia, numero, tel, telCasa, Manager.UsuarioIS, contra, actual, contraAnt, null);
                MessageBox.Show("Usuario modificado correctamente!", "Ok! :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DGV_Usuarios.DataSource = _instanceManager.SelectTodosUsuarios();
            }
            else
            {
                MessageBox.Show("Oh no! \nParece que no llenaste todos los datos", "Okn't :(", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            passChanged = false;
            T_pass.Enabled = false;

            T_Apellido.Enabled = false;
            T_name.Enabled = false;

            T_calle.Enabled = false;
            T_Colonia.Enabled = false;
            T_numero.Enabled = false;

            T_Tel.Enabled = false;
            T_TelCasa.Enabled = false;
            RB_Operador.Enabled = false;
            RB_Admin.Enabled = false;

            B_Aceptar.Enabled = false;
            B_EditarPass.Enabled = false;

        }

        private void Gestion_Usuario_Load(object sender, EventArgs e)
        {
            DGV_Usuarios.DataSource = _instanceManager.SelectTodosUsuarios();
            string stringRan = _instanceManager.StringRandom();

            int i = 0;


        }

        private void DGV_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            T_email.Text = DGV_Usuarios.CurrentRow.Cells["email"].Value.ToString();
            T_pass.Text = DGV_Usuarios.CurrentRow.Cells["currentps"].Value.ToString();

            T_rfc.Text = DGV_Usuarios.CurrentRow.Cells["employeenumber"].Value.ToString();
            T_Apellido.Text = DGV_Usuarios.CurrentRow.Cells["lastName"].Value.ToString();
            T_name.Text = DGV_Usuarios.CurrentRow.Cells["firstName"].Value.ToString();
            DTP_FechaNacimiento.Value = DateTime.Parse(DGV_Usuarios.CurrentRow.Cells["birthdate"].Value.ToString());

            T_calle.Text = DGV_Usuarios.CurrentRow.Cells["street"].Value.ToString();
            T_Colonia.Text = DGV_Usuarios.CurrentRow.Cells["neighborhood"].Value.ToString();
            T_numero.Text = DGV_Usuarios.CurrentRow.Cells["number"].Value.ToString();

            T_Tel.Text = DGV_Usuarios.CurrentRow.Cells["tel1"].Value.ToString();
            T_TelCasa.Text = DGV_Usuarios.CurrentRow.Cells["tel2"].Value.ToString();

            string usertype = DGV_Usuarios.CurrentRow.Cells["userType"].Value.ToString();

            if (usertype == "1")
            {
                RB_Admin.Checked = true;
            }
            else
            {
                RB_Operador.Checked = true;
            }


            if ((bool)DGV_Usuarios.CurrentRow.Cells["statusPass"].Value == true)
            {
                B_Habilitar.Enabled = true;
            }
            else
            {
                B_Habilitar.Enabled = false;
            }

        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            T_Apellido.Enabled = true;
            T_name.Enabled = true;

            T_calle.Enabled = true;
            T_Colonia.Enabled = true;
            T_numero.Enabled = true;

            T_Tel.Enabled = true;
            T_TelCasa.Enabled = true;
            RB_Operador.Enabled = true;
            RB_Admin.Enabled = true;

            B_Aceptar.Enabled = true;
            B_EditarPass.Enabled = true;

        }

        private void B_CrearUser_Click(object sender, EventArgs e)
        {
            Crear_Usuario crear_User = new Crear_Usuario();
            crear_User.Show();
        }

        private void B_EditarPass_Click(object sender, EventArgs e)
        {
            passChanged = true;
            T_pass.Enabled = true;
        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            if (DGV_Usuarios.CurrentRow.Cells["email"].Value != null)
            {
                string email = DGV_Usuarios.CurrentRow.Cells["email"].Value.ToString();

                _instanceManager.EliminarUsuario(email);
                DGV_Usuarios.DataSource = _instanceManager.SelectTodosUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario a eliminar!", "!?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void B_Habilitar_Click(object sender, EventArgs e)
        {

            string PassTemp = _instanceManager.StringRandom();
            string email;
            string actual;
            string anterior = "";
            string strnull = "";

            actual = DGV_Usuarios.CurrentRow.Cells["currentps"].Value.ToString();
            email = DGV_Usuarios.CurrentRow.Cells["email"].Value.ToString();

            if (DGV_Usuarios.SelectedRows[0].Cells["past"].Value != null)
            {
                anterior = DGV_Usuarios.SelectedRows[0].Cells["past"].Value.ToString();
            }


            _instanceManager.CambiarContraseña(email, strnull, actual, anterior, PassTemp);
            MessageBox.Show("Usuario rehabilitado correctamente!", "Ok! :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DGV_Usuarios.DataSource = _instanceManager.SelectTodosUsuarios();
        }

        private void Gestion_Usuario_Activated(object sender, EventArgs e)
        {
            DGV_Usuarios.DataSource = _instanceManager.SelectTodosUsuarios();
        }
    }
}
