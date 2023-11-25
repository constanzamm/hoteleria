using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoteleria.Dto
{
    class UserLoginDto
    {
        public String email {  get; set; }
        public String password { get; set; }
        public int employeeNumber { get; set; }
        public String status { get; set; }
        public int userType { get; set; }
    }
}
