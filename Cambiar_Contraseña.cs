using hoteleria.Database;
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

namespace hoteleria
{
    public partial class Cambiar_Contraseña : Form
    {

        private Manager _instanceManager;

        public Cambiar_Contraseña()
        {
            InitializeComponent();
            _instanceManager = Manager.getInstance();

            if (Manager.rehabilitado == true)
            {
                this.ControlBox = false;
                this.MaximizeBox = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nueva = T_pass.Text;
            string nuevaConfirmed = T_ContraConfirmada.Text;
            string strnull = "";
            string actual = "";

            string contraAnt = "";
            string contraAnt2 = "";

            try
            {
                if (_instanceManager.RegresaAlgunDato(Manager.UsuarioIS, "currentps") != "")
                {
                    actual = _instanceManager.RegresaAlgunDato(Manager.UsuarioIS, "currentps");
                }

                if (_instanceManager.RegresaAlgunDato(Manager.UsuarioIS, "past") != "")
                {
                    contraAnt = _instanceManager.RegresaAlgunDato(Manager.UsuarioIS, "past");
                }

                if (_instanceManager.RegresaAlgunDato(Manager.UsuarioIS, "past2") != "")
                {
                    contraAnt2 = _instanceManager.RegresaAlgunDato(Manager.UsuarioIS, "past2");
                }

                if (nueva != contraAnt && nueva != contraAnt2 && nueva == nuevaConfirmed && actual != "")
                {
                    _instanceManager.CambiarContraseña(Manager.UsuarioIS, nueva, actual, contraAnt, strnull);
                    MessageBox.Show("Contraseña cambiada correctamente!", "Ok :)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (nueva != contraAnt && nueva != contraAnt2 && nueva == nuevaConfirmed)
                {
                    _instanceManager.CambiarContraseña(Manager.UsuarioIS, nueva, contraAnt, contraAnt2, strnull);
                    MessageBox.Show("Contraseña cambiada correctamente!", "Ok :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ControlBox = true;
                    this.MaximizeBox = true;
                    Manager.rehabilitado = false;
                }
                else
                {
                    MessageBox.Show("Oh no! \n Las contraseña es incorrecta", "Okn't :(", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
            catch
            {

                MessageBox.Show("Oh no! \n Error", "Okn't :(", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
