using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using hoteleria.Dto;

namespace hoteleria
{
    internal class Reservacion
    {
        public Guid RevNum { get; set; }
        public int numRoomRev {  get; set; }
        public LocalDate fechaEntrada { get; set; }
        public LocalDate fechaSalida { get; set; }
        public LocalDate fechaCheckIn { get; set; }
        public LocalDate fechaCheckOut { get; set; }
        public string paisRev {  get; set; }
        public string cityRev { get; set; }
        public string hotelRev { get; set; }
        public string lastNameRev { get; set; }
        public string emailCli { get; set; }
        public string rfcRev { get; set; }
        public string roomTypeRev { get; set; }
        public List<string> amenities { get; set; }
        public float AnticipoRev { get; set; }
        public int maxPeopleRev { get; set; }
        public int PeopleInsideREV { get; set; }
        public bool RevNumStatus { get; set; }
        public string userR {  get; set; }
        public DateTime dateTimeR {  get; set; }
        public string metodoPago { get; set; }  
        public float totalRev { get; set; }
        public DateTime FechaEntrada()
        {
            DateTime fecha = new DateTime(this.fechaEntrada.Year, this.fechaEntrada.Month, this.fechaEntrada.Day);
            return fecha;
        }
        public DateTime FechaSalida()
        {
            DateTime fecha = new DateTime(this.fechaSalida.Year, this.fechaSalida.Month, this.fechaSalida.Day);
            return fecha;
        }
    }
}
