using Cassandra;
using hoteleria.Database;
using hoteleria.Dto;
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

namespace hoteleria
{
    public partial class Habitaciones : Form
    {
        private Manager _instanceManager;
        bool correcto;
        public Habitaciones()
        {
            InitializeComponent();
            _instanceManager = Manager.getInstance();
            CB_TipodeCama.Items.Add("Individual");
            CB_TipodeCama.Items.Add("Matrimonial");
            CB_TipodeCama.Items.Add("Queen Size");
            CB_TipodeCama.Items.Add("King Size");
            CB_NivelHabitacion.Items.Add("Economica");
            CB_NivelHabitacion.Items.Add("Estandar");
            CB_NivelHabitacion.Items.Add("De Lujo");
            CB_NivelHabitacion.Items.Add("Premium");
            CB_NivelHabitacion.Items.Add("Suite Presidencial");
        }

        private void CLB_Caracteristicas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Habitaciones_Load(object sender, EventArgs e)
        {

        }

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            correcto = true;
            int cantperso=0;
            float precio=0;
            int numcam=0;
            int numhab=0;
            string idhotel = TB_IDHotel.Text;
            string type = TB_NomTipoHab.Text;
            List<string> amenities = ConvertirIListAListString(CLB_Caracteristicas.CheckedItems);
          if( int.TryParse(TB_NumHabitacion.Text, out int resultado)) {
                // La conversión fue exitosa, y el resultado está almacenado en la variable 'resultado'
                // Asigna el resultado a una variable
                numhab = resultado;
            }
            else
            {
                correcto = false;
            }
            if (int.TryParse(TB_NumCamas.Text, out int resultado2))
            {
                // La conversión fue exitosa, y el resultado está almacenado en la variable 'resultado'
                // Asigna el resultado a una variable
                numcam = resultado2;

            }
            else
            {
                correcto = false;
            }
            string tipcam = CB_TipodeCama.Text;
            if (float.TryParse(TB_Precio.Text, out float resultado3))
            {
                // La conversión fue exitosa, y el resultado está almacenado en la variable 'resultado'

                // Asigna el resultado a una variable de tipo float
                precio = resultado3;
            }
            else
            {
                correcto = false;
            }
            if (int.TryParse(TB_CantidadPersonas.Text, out int resultado4))
            {
                // La conversión fue exitosa, y el resultado está almacenado en la variable 'resultado'
                // Asigna el resultado a una variable
                cantperso = resultado4;
            }
            else
            {
               correcto=false;
            }
            string nivel = CB_NivelHabitacion.Text;
            string userR = Manager.UsuarioIS;
            if (correcto)
            {
                _instanceManager.InsertarDatosHabitacion(idhotel, type, amenities, numhab, numcam, precio, cantperso, tipcam, nivel, userR);
            }
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

    
    }
}
