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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace hoteleria
{
    public partial class Hoteles : Form
    {
        private Manager _instanceManager;
        bool correcto;

        public Hoteles()
        {
            _instanceManager = Manager.getInstance();

            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void B_AgregarTipoHabitaciones_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones();
            habitaciones.ShowDialog();
        }

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            Boolean ZT;
            string nomhot=  TB_NomHotel.Text;
            string ciudad=TB_Ciudad.Text;
            string estado=TB_Estado.Text;
            string pais=TB_Pais.Text;
            string calle = TB_Calle.Text;
            string col=TB_Colonia.Text;
            int numext = 0;
            int numpis = 0;
            if (int.TryParse(TB_NumExt.Text, out int resultado))
            {
                // La conversión fue exitosa, y el resultado está almacenado en la variable 'resultado'
                // Asigna el resultado a una variable
                numext = resultado;
            }
            else
            {
                correcto = false;
            }
            if (int.TryParse(TB_NumPis.Text, out int resultado2))
            {
                // La conversión fue exitosa, y el resultado está almacenado en la variable 'resultado'
                // Asigna el resultado a una variable
                numpis = resultado2;

            }
            else
            {
                correcto=false;
            }

            if (RB_ZonaT.Checked)
            {
                ZT = true;  // RadioButton 1 está seleccionado
            }
            else
            {
                // Si lo deseas, puedes establecer un valor predeterminado si ningún RadioButton está seleccionado
                ZT = false; // RadioButton 1 no está seleccionado
            }
            List<string> additionalService = ConvertirIListAListString(CLB_Caracteristicas.CheckedItems);
            DTP_InicioOperaciones.Format = DateTimePickerFormat.Custom;
            DTP_InicioOperaciones.CustomFormat = "yyyy-MM-dd";
            string fechaI = DTP_InicioOperaciones.Text.ToString();
            string userR= Manager.UsuarioIS;
            _instanceManager.InsertarHotel(nomhot, ciudad, estado, pais, calle, col, numext, numpis, ZT, additionalService, userR, fechaI);

        }
        private List<string> ConvertirIListAListString(IList lista)
        {
            List<string> listaDeStrings = new List<string>();

            foreach (var elemento in lista)
            {
                // Convierte cada elemento a tipo string y agrega a la lista
                listaDeStrings.Add(elemento.ToString());
            }

            return listaDeStrings;
        }

        private void Hoteles_Load(object sender, EventArgs e)
        {

        }

        private void B_Editar_Click(object sender, EventArgs e)
        {
            Boolean ZT;
            string nomhot = TB_NomHotel.Text;
            string ciudad = TB_Ciudad.Text;
            string estado = TB_Estado.Text;
            string pais = TB_Pais.Text;
            string calle = TB_Calle.Text;
            string col = TB_Colonia.Text;
            int numext = 0;
            int numpis = 0;
            if (int.TryParse(TB_NumExt.Text, out int resultado))
            {
                // La conversión fue exitosa, y el resultado está almacenado en la variable 'resultado'
                // Asigna el resultado a una variable
                numext = resultado;
            }
            else
            {
                correcto = false;
            }
            if (int.TryParse(TB_NumPis.Text, out int resultado2))
            {
                // La conversión fue exitosa, y el resultado está almacenado en la variable 'resultado'
                // Asigna el resultado a una variable
                numpis = resultado2;

            }
            else
            {
                correcto = false;
            }

            if (RB_ZonaT.Checked)
            {
                ZT = true;  // RadioButton 1 está seleccionado
            }
            else
            {
                // Si lo deseas, puedes establecer un valor predeterminado si ningún RadioButton está seleccionado
                ZT = false; // RadioButton 1 no está seleccionado
            }
            List<string> additionalService = ConvertirIListAListString(CLB_Caracteristicas.CheckedItems);
            string idHotel=TB_IDEditar.Text;
            _instanceManager.EditarHotel(nomhot,ciudad,estado, pais, calle,col,numext,numpis,ZT,additionalService,idHotel);

        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            string idHotel = TB_ID.Text;
            _instanceManager.EliminarHotel(idHotel);
        }
    }
}
