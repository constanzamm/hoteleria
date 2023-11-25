using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoteleria
{
    public partial class Habitacion
    {
        public string hotel { get; set; }
        public int roomNum { get; set; }
        public int bedNum { get; set; }
        public string bedType { get; set; }
        public string type { get; set; }
        public List<string> amenities { get; set; }
        public float price { get; set; }
        public int maxPeople { get; set; }
        public string level { get; set; }
        public bool status { get; set; }
    }
}
