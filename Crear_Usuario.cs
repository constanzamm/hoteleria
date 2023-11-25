using hoteleria.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace hoteleria
{
    public partial class Crear_Usuario : Form
    {
        private Manager _instanceManager;

        public Crear_Usuario()
        {
            InitializeComponent();
            _instanceManager = Manager.getInstance();
        }

        private void Crear_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void B_Editar_Click(object sender, EventArgs e)
        {



        }

        private void DTP_FechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
            try
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

            if (email != "" && contra != "" && rfc != "" && apellido != "" && nombre != "" && calle != "" && colonia != "" && tel != "" && telCasa != "" && (RB_Admin.Checked || RB_Operador.Checked))
            {
                _instanceManager.CrearUsuario(email, rfc, apellido, nombre, tipo, fechaNacimiento, calle, colonia, numero, tel, telCasa, Manager.UsuarioIS, contra, null, null, null);
                MessageBox.Show("Usuario creado correctamente!", "Ok! :)", MessageBoxButtons.OK, MessageBoxIcon.Information);


                T_email.Clear();
                T_pass.Clear();

                T_Apellido.Clear();
                T_name.Clear();

                T_calle.Clear();
                T_Colonia.Clear();
                T_numero.Clear();

                T_Tel.Clear();
                T_TelCasa.Clear();
                RB_Operador.Checked = false;
                RB_Admin.Checked = false;

            }
            else
            {
                MessageBox.Show("Todos los datos deben ser llenado!", "Okn't :(", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            }
            catch
            {
                MessageBox.Show("Memori", "Okn't :(", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
