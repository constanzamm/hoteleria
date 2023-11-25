using Cassandra;
using hoteleria.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hoteleria
{
    public partial class Hotel
    {
        public string namehotel { get; set; }
        public Guid id {  get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public int floorNum { get; set; }
        public int roomNum { get; set; }

        public string street { get; set; }
        public string neighborhood { get; set; }
        public int number { get; set; }

        public List<string> roomtype { get; set; }
        //aditional service
        public int quantitytypes { get; set; }
        //public Registro registro;
        public bool status { get; set; }
        public LocalDate start { get; set; }

        //additionalService LIST<VARCHAR>,

    }
}
