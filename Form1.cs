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

namespace hoteleria
{
    public partial class Form1 : Form
    {
        private Manager _instanceManager;
        public bool endApp = true;
        public Form1()
        {
            InitializeComponent();
            _instanceManager = Manager.getInstance();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String email = 
                emailTxt.Text.ToString().Trim() == "" ? 
                    "NO" : emailTxt.Text.ToString();

            String password =
                passTxt.Text.ToString().Trim() == "" ?
                    "NO" : passTxt.Text.ToString();

            //byte[] encPass = new byte[password.Length];
            //encPass = System.Text.Encoding.UTF8.GetBytes(password);
            //string encData = Convert.ToBase64String(encPass);

            //List<UserLoginDto> users = 
            //  _instanceManager.login(email, encData);

            //https://www.base64encode.org/

            /*if (users.Count <= 0){
                MessageBox.Show("Credenciales no validas");
                return;
            }
            UserLoginDto user = users[0];
            */

            if (_instanceManager.ObtenerUsuarioPorEmail(email, password))
            {
                MessageBox.Show("Inicio de sesion correcto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Home homescreen = new Home();
                homescreen.Show();
                endApp = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Inicio de sesion fallido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(endApp)
            {
               Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
