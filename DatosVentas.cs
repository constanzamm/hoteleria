using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using Cassandra;
using hoteleria.Dto;

namespace hoteleria.Dto
{
    internal class DatosVentas
    {
        public string Pais { get; set; }
        public DateTime Fecha { get; set; }
        public string Año_Mes{ get; set; }
        public string Ciudad { get; set; }
        public string Hotel { get; set; }
        public float Total_Hospedaje { get; set; }
        public float Total_Servicios { get; set; }
        public float Total { get; set; }
        public void init_Price()
        {
            this.Total_Servicios += Total_Hospedaje * 0.05f;
            this.Total += Total_Hospedaje * 1.05f;
        }
    }
}
