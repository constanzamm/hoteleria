using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hoteleria.Dto
{
    class room_type
    {
        public String type {  get; set; }
        public List<String> amenities { get; set; }
    }
}
