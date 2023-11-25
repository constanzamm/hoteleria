using Cassandra;
using Cassandra.Data.Linq;
using hoteleria.Database;
using hoteleria.Entity;
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
    public partial class CheckIn : Form
    {

        private Manager _instanceManager;
        public CheckIn()
        {

            _instanceManager = Manager.getInstance();
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CodRev = CodResvTx.Text;
            LocalDate fechacheckin = LocalDate.Parse(DTP_CheckIn.Value.ToString("yyyy-MM-dd"));
            _instanceManager.CheckInConf(CodRev,fechacheckin);
           
        }
    }
}

//Agregar datetimepicker al home y ponerle variable global.
// Creo que ya jala checkin solo falta que nos pasen el funcionamiento de las reservaciones oscar y yas