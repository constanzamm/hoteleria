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
using hoteleria.Dto;
using Cassandra;

namespace hoteleria.Dto
{
    internal class HistClient
    {
        public String RFCHIST { get; set; }
        public String CityHist { get; set; }
        public String HotelHist { get; set; }
        public String roomTypeHist { get; set; }
        public int PeopleInsideREVHist { get; set; }
        public Guid ID_REV { get; set; }
        public LocalDate FechaReservacionHist { get; set; }
        public LocalDate FechaEntradaHist { get; set; }
        public LocalDate FechaSalidaHist { get; set; }
        public bool RevNumStatusHist { get; set; }
        public float RevAnticipoHist { get; set; }
        public float MontoHospedajeHist { get; set; }
        public float MontoServiciosHist { get; set; }
        public float TotalFacturaHist { get; set; }

    }



}
