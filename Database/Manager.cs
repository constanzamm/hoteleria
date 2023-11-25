using Cassandra;
using Cassandra.Mapping;
using hoteleria.Dto;
using hoteleria.Entity;
using hoteleria.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoteleria.Database
{
    internal class Manager
    {    
        static string historial=null;

        static private String keyspace {  get; set; }
        static private String ipHome { get; set; }
        static private Cluster cluster;
        static private ISession session;
        static public bool rehabilitado;
        static public string UsuarioIS;
        static private Manager _instance; //variable instancia statica
        private Manager() { // Constructor privado
            keyspace = 
                ConfigurationSettings.AppSettings["keyspace"].ToString();
            ipHome = 
                ConfigurationSettings.AppSettings["cassandra_home"].ToString();

            cluster = Cluster.Builder().AddContactPoint(ipHome).Build();

            session = cluster.Connect(keyspace);    
        }
        //Nos va a devolver la unica instancia de "Manager"
        public static Manager getInstance() {
            if( _instance == null){
                _instance = new Manager();
            }
            return _instance;
        }

            public bool ObtenerUsuarioPorEmail(string email, string password)
        {
            try
            {
            var selectStatement = session.Prepare("SELECT * FROM TRIVAGO.USUARIOS WHERE email = ?");
            var boundStatement = selectStatement.Bind(email);
            var result = session.Execute(boundStatement);

            var row = result.FirstOrDefault();

            if (row != null)
            {
                User usuario = new User();
                usuario.email = row.GetValue<string>("email");
                usuario.currentps = row.GetValue<string>("currentps");
                usuario.temp = row.GetValue<string>("temp");
                usuario.intentosInicio = row.GetValue<int>("intentosinicio");
                usuario.status=row.GetValue<Boolean>("status");
                usuario.statusPass = row.GetValue<Boolean>("statuspass");
                if(usuario.currentps == "")
                {
                        if (usuario.temp == password && usuario.status == true)
                        {
                            UsuarioIS = usuario.email;
                            rehabilitado = true;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                       if (usuario.currentps == password&&usuario.status==true&&usuario.statusPass==false)
                         {
                           UsuarioIS = usuario.email;
                           return true;
                         }
                        else
                        {
                            int a = usuario.intentosInicio + 1;
                            if (a > 3&&usuario.statusPass==false && usuario.status == true)
                            {
                                var desa=$"UPDATE TRIVAGO.USUARIOS "+
                                    $"SET statusPass=true "+
                                    $"WHERE email = '{email}';";
                                session.Execute(desa);
                                MessageBox.Show("Demasiados intentos, se ha deshabilitado el usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else if(a<=3 && usuario.status == true)
                            {
                            var intento = $"UPDATE TRIVAGO.USUARIOS " +
                            $"SET intentosInicio = {a} " +
                            $"WHERE email = '{email}';";
                            session.Execute(intento);
                            MessageBox.Show("Contraseña Incorrecta, O usuario inhabilitado/eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
            }
                 return false;
            }
            catch
            {
                MessageBox.Show("Error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void InsertarDatosHabitacion(string idhotel, string type, List<string> amenities, int numhab, int numcam, float precio, int cantperso, string tipcam, string nivel, string userR)
        {
            try
            {
            string insertQuery = $"INSERT INTO TRIVAGO.HABITACIONES " +
                         "(hotel, type, amenities, roomNum, bedNum, bedType, price, maxPeople, level, userR, dateTimeR, status) VALUES " +
                         $"('{idhotel}', '{type}', {ConvertAmenitiesToCqlList(amenities)}, {numhab}, {numcam}, '{tipcam}', {precio}, {cantperso}, '{nivel}', '{userR}', toTimestamp(now()), true);";

            session.Execute(insertQuery);
            // ID del hotel para el cual deseas obtener la información
            // Consulta CQL para obtener la cantidad de cuartos y tipos de cuartos
            var cqlQuery = $"SELECT type, COUNT(roomNum) AS cantidadCuartos, COUNT(type) AS cantidadTiposCuartos " +
               $"FROM TRIVAGO.HABITACIONES " +
               $"WHERE hotel = '{idhotel}' ALLOW FILTERING;";

            // Ejecutar la consulta
            var resultSet = session.Execute(cqlQuery);

            // Variables para almacenar los resultados
            long totalCuartos = 0;
            int cantidadTiposCuartos = 0;

            // Procesa los resultados
            foreach (var row in resultSet)
            {
                string tipoCuarto = row.GetValue<string>("type");
                long cantidadCuarto = row.GetValue<long>("cantidadcuartos");

                // Incrementa el total de cuartos
                totalCuartos += cantidadCuarto;
            }
            int intValue = Convert.ToInt32(totalCuartos);
            // Query para seleccionar todas las habitaciones de un hotel y obtener sus tipos
            var setquery = $"SELECT type FROM TRIVAGO.HABITACIONES WHERE hotel = '{idhotel}' ALLOW FILTERING";

            // Ejecutar la consulta
            var res = session.Execute(setquery);

            // Crear un HashSet para almacenar los tipos de habitaciones
            HashSet<string> tiposUnicos = new HashSet<string>();

            // Iterar sobre los resultados y agregar los tipos al HashSet
            foreach (var row in res)
            {
                string tipoHabitacion = row.GetValue<string>("type");
                tiposUnicos.Add(tipoHabitacion);
            }
            cantidadTiposCuartos = tiposUnicos.Count;
            // Verificar si hay tipos de habitaciones únicos
            if (tiposUnicos.Count > 0)
            {
                // Convertir el conjunto a formato compatible con CQL (entre comillas simples y separado por comas)
                string tiposCql = string.Join(",", tiposUnicos.Select(tipo => $"'{tipo}'"));

                // Actualizar la tabla de HOTELES con los tipos de habitaciones únicos
                var updateQuery = $"UPDATE TRIVAGO.HOTELES " +
                                   $"SET roomNum = {intValue}, quantityTypes = {cantidadTiposCuartos}, roomtype = {{{tiposCql}}}" +
                       $"WHERE id = {idhotel};";

                // Ejecutar la actualización
                session.Execute(updateQuery);
            }
            else
            {
                MessageBox.Show("El hotel no se encontro","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            }
            catch
            {
                MessageBox.Show("No se pudo agregar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<string> ConvertSetToList(HashSet<string> inputSet)
        {
            // Convierte el HashSet a List
            List<string> outputList = new List<string>(inputSet);
            return outputList;
        }
        private string ConvertAmenitiesToCqlList(List<string> amenities)
        {
            return $"[{string.Join(",", amenities.Select(a => $"'{a}'"))}]";
        }
        public void InsertarHotel(string nomhot, string ciudad, string estado, string pais, string calle,
                                  string col, int numext, int numpis, bool ZT, List<string> additionalService, string userR, string fechaI)
        {
            try
            {
            // Generar un UUID para id
            Guid idHotel = Guid.NewGuid();
            // Consulta de inserción
            var cqlQuery = $"INSERT INTO TRIVAGO.HOTELES " +
                           $"(nameHotel,id, city, state, country, street, neighborhood, number, floorNum, roomNum, " +
                           $"roomtype, Tzone, additionalService, userR, dateTimeR, status, start) " +
                           $"VALUES " +
                           $"('{nomhot}', {idHotel},'{ciudad}', '{estado}', '{pais}', '{calle}', '{col}', {numext}, " +
                           $"{numpis}, 0,null, {ZT}, {ConvertADToCqlList(additionalService)}, '{userR}', toTimestamp(now()), true, '{fechaI}');";

            // Ejecutar la consulta
            session.Execute(cqlQuery);

            }
            catch
            {
                MessageBox.Show("No se pudo agregar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EditarHotel(string nomhot, string ciudad, string estado, string pais, string calle,
                                  string col, int numext, int numpis, bool ZT, List<string> additionalService,string idHotel)
        {
            try
            {
            // Query para actualizar la tabla HOTELES
            var updateQuery = $"UPDATE TRIVAGO.HOTELES " +
                              $"SET nameHotel = '{nomhot}', city = '{ciudad}', state = '{estado}', country = '{pais}', " +
                              $"street = '{calle}', neighborhood = '{col}', number = {numext}, floorNum = {numpis}, " +
                              $"Tzone = {ZT}, additionalService = {ConvertADToCqlList(additionalService)} " +
                              $"WHERE id = {idHotel};";

            // Ejecutar la actualización
            session.Execute(updateQuery);
            }
            catch
            {
                MessageBox.Show("No se pudo editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void EliminarHotel(string idHotel)
        {
            try
            {
            // Query para actualizar el campo status en la tabla HOTELES
            var updateStatusQuery = $"UPDATE TRIVAGO.HOTELES " +
                                    $"SET status = false " +
                                    $"WHERE id = {idHotel};";

            // Ejecutar la actualización
            session.Execute(updateStatusQuery);
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string ConvertADToCqlList(List<string> additionalService)
        {
            // Convierte la lista de amenidades a una cadena CQL que representa una lista
            return "[" + string.Join(",", additionalService.Select(a => $"'{a}'")) + "]";
        }
        //public List<UserLoginDto> login(String email,String password) {
        //    string query = 
        //        String.Format(Queries.USER_LOGIN, email, password);
        //    session.Execute(query);
        //    IMapper mapper = new Mapper(session);
        //    IEnumerable<UserLoginDto> users = 
        //        mapper.Fetch<UserLoginDto>(query);
        //    return users.ToList();
        //}
        // CLIENTES //
        public List<Cliente> get_Clients()
        {
            session.Execute("SELECT FirstName, LastName, street, neighborhood, number, rfc, emailCli, tel1, tel2, reference, birthdateCLI, civilStatus, userR, datetimeR, status FROM CLIENT");
            IMapper mapper = new Mapper(session);
            IEnumerable<Cliente> clients =
                mapper.Fetch<Cliente>("SELECT FirstName, LastName, street, neighborhood, number, rfc, emailCli, tel1, tel2, reference, birthdateCLI, civilStatus, userR, datetimeR, status FROM CLIENT");
            return clients.ToList();
        }
        public string NombreHotel(string idHotel)
        {
            var updateStatusQuery = $"SELECT nameHotel FROM TRIVAGO.HOTELES " +
                                    $"WHERE id = {idHotel};";

            // Ejecutar la actualización
            var result = session.Execute(updateStatusQuery);
            string hotel = "";
            var row = result.FirstOrDefault();

            if (row != null)
            {
                hotel =row.GetValue<string>("namehotel");
                return hotel;
            }
            return hotel;
        }
        public List<Cliente> get_Client(string rfc)
        {
            session.Execute($"SELECT FirstName, LastName, street, neighborhood, number, rfc, emailCli, contactCLI, reference, birthdateCLI, civilStatus, userR, datetimeR, status FROM CLIENT WHERE rfc = {rfc}");
            IMapper mapper = new Mapper(session);
            IEnumerable<Cliente> clients =
                mapper.Fetch<Cliente>($"SELECT FirstName, LastName, street, neighborhood, number, rfc, emailCli, contactCLI, reference, birthdateCLI, civilStatus, userR, datetimeR, status FROM CLIENT WHERE rfc = {rfc}");
            return clients.ToList();
        }

        public void insert_Clients(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {
                    if (cliente.ValidacionCorreo())
                    {
                        //string query =
                        //String.Format(Queries.INSERT_CLIENT, cliente.FirstName, cliente.LastName, cliente.street, cliente.neighborhood, cliente.number, cliente.rfc, cliente.emailCLI, cliente.contact[0], cliente.contact[0], cliente.reference, cliente.birthdate, cliente.civilStatus, cliente.userR, cliente.dateTimeR);
                        var query = $"INSERT INTO CLIENT(FirstName, LastName, street, neighborhood, number, rfc, emailCli, tel1, tel2,  reference, birthdateCLI, civilStatus, userR, datetimeR, status) " +
                                    $"VALUES('{cliente.FirstName}', '{cliente.LastName}', '{cliente.street}', '{cliente.neighborhood}', {cliente.number}, '{cliente.rfc}', '{cliente.emailCLI}', '{cliente.tel1}', '{cliente.tel2}', '{cliente.reference}', '{cliente.birthdateCLI}', '{cliente.civilStatus}', '{cliente.userR}', toTimestamp(now()), 1);";

                        //INSERT INTO proyecto_aavd.CLIENT (FirstName, LastName, street, neighborhood, number, rfc, emailCli, contactCLI, reference, birthdateCLI, civilStatus, userR, datetimeR, status)
                        //VALUES('Max', 'Zertuche', 'popo', 'A', 12, 'MAZP000012SF', 'max@hotmail.com', { '83000000'}, 'Amigo', '2018-04-01', 'Soltero', 'imsis', toTimestamp(now()), 1);

                        session.Execute(query);
                    }
                    else throw new InvalidOperationException("Correo no válido");
                }
                else throw new InvalidOperationException("Cliente es nulo");


            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error en la función insert_Clients en clase Manager", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete_Clients(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                {
                    //string query =
                    //String.Format(Queries.DELETE_CLIENT, cliente.emailCLI);
                    var query = $"UPDATE CLIENT SET status = 0 WHERE rfc = '{cliente.rfc}'";
                    session.Execute(query);
                }
                else throw new InvalidOperationException("Cliente es nulo");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error en la función delete_Clients en clase Manager", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<HistClient> get_HistClients()
        {
            var query = "SELECT RFCHIST, CityHist, HotelHist, roomTypeHist, PeopleInsideREVHist, ID_REV,FechaReservacionHist, FechaEntradaHist, FechaSalidaHist, RevNumStatusHist, RevAnticipoHist,\r\n MontoHospedajeHist, MontoServiciosHist, TotalFacturaHist FROM HistCliente;";
            session.Execute(query);
            IMapper mapper = new Mapper(session);
            IEnumerable<HistClient> hist =
                mapper.Fetch<HistClient>("SELECT RFCHIST, CityHist, HotelHist, roomTypeHist, PeopleInsideREVHist, ID_REV,\r\nFechaReservacionHist, FechaEntradaHist, FechaSalidaHist, RevNumStatusHist, RevAnticipoHist,\r\n MontoHospedajeHist, MontoServiciosHist, TotalFacturaHist FROM HistCliente;");
            return hist.ToList();
        }
        public void AgregarHistorial(string lastName,
        string email,
        string rfc,
        string firstName,
        string city,
        string hotel,
        string roomType,
        int roomNum,
        int peopleInside,
        LocalDate fechaEntrada,
        LocalDate fechaSalida,
        LocalDate fechaReservacion,
        bool revNumStatus, 
        float revAnticipo,
        float montoHospedaje,
        double montoServicios,
        double totalFactura)
        {
            var insertQuery = $"INSERT INTO HistCliente (ID_REV, LastNameHist, emailHist, RFCHIST, FirstNameHist, CityHist, " +
                          $"HotelHist, roomTypeHist, roomNumHist, PeopleInsideREVHist, RevNumHist, FechaEntradaHist, " +
                          $"FechaSalidaHist, FechaReservacionHist, RevNumStatusHist, RevAnticipoHist, " +
                          $"MontoHospedajeHist, MontoServiciosHist, TotalFacturaHist) VALUES (" +
                          $"UUID(), '{lastName}', '{email}', '{rfc}', '{firstName}', '{city}', '{hotel}', " +
                          $"'{roomType}', '{roomNum}', {peopleInside}, '{historial}', '{fechaEntrada}', '{fechaSalida}', " +
                          $"'{fechaReservacion}', {revNumStatus}, {revAnticipo}, {montoHospedaje}, {montoServicios}, {totalFactura});";

            // Ejecutar la consulta
            session.Execute(insertQuery);
        }
        public List<HistClient> get_HistClient(Cliente cliente)
        {
            session.Execute($"SELECT RFCHIST, CityHist, HotelHist, roomTypeHist, PeopleInsideREVHist, ID_REV,\r\nFechaReservacion, FechaEntradaHist, FechaSalidaHist, RevNumStatusHist, RevAnticipoHist,\r\n MontoHospedajeHist, MontoServiciosHist, TotalFacturaHist FROM HistCliente WHERE RFCHIST = '{cliente.rfc}' ALLOW FILTERING;;");
            IMapper mapper = new Mapper(session);
            IEnumerable<HistClient> hist =
                mapper.Fetch<HistClient>($"\r\nSELECT RFCHIST, CityHist, HotelHist, roomTypeHist, PeopleInsideREVHist, ID_REV,\r\nFechaReservacion, FechaEntradaHist, FechaSalidaHist, RevNumStatusHist, RevAnticipoHist,\r\n MontoHospedajeHist, MontoServiciosHist, TotalFacturaHist FROM HistCliente WHERE RFCHIST = '{cliente.rfc}' ALLOW FILTERING;;");
            return hist.ToList();
        }

        public List<HistClient> get_HistClient(string rfc)
        {
            session.Execute($"SELECT RFCHIST, CityHist, HotelHist, roomTypeHist, PeopleInsideREVHist, ID_REV,\r\nFechaReservacionHist, FechaEntradaHist, FechaSalidaHist, RevNumStatusHist, RevAnticipoHist,\r\n MontoHospedajeHist, MontoServiciosHist, TotalFacturaHist FROM HistCliente WHERE RFCHIST = '{rfc}' ALLOW FILTERING;");
            IMapper mapper = new Mapper(session);
            IEnumerable<HistClient> hist =
                mapper.Fetch<HistClient>($"SELECT RFCHIST, CityHist, HotelHist, roomTypeHist, PeopleInsideREVHist, ID_REV,\r\nFechaReservacionHist, FechaEntradaHist, FechaSalidaHist, RevNumStatusHist, RevAnticipoHist,\r\n MontoHospedajeHist, MontoServiciosHist, TotalFacturaHist FROM HistCliente WHERE RFCHIST = '{rfc}' ALLOW FILTERING;");
            return hist.ToList();
        }
        //REPORTE DE VENTAS
        public List<Reservacion> get_ReporteVentas()
        {
            session.Execute($"SELECT paisRev, cityRev, hotelRev, dateTimeR, AnticipoReV FROM TRIVAGO.RESERVACIONES;");
            IMapper mapper = new Mapper(session);
            IEnumerable<Reservacion> hist =
                mapper.Fetch<Reservacion>($"\r\nSELECT paisRev, cityRev, hotelRev, dateTimeR, AnticipoReV FROM TRIVAGO.RESERVACIONES;");
            return hist.ToList();
        }
        // CheckIn
        public void CheckInConf(string CodRev, LocalDate fechacheckin)
        {
            try
            {

                var cqlQuery = $"SELECT numRoomRev,fechaEntrada,fechaCheckIn FROM TRIVAGO.RESERVACIONES WHERE RevNum = {CodRev} ALLOW FILTERING";
                Row result = session.Execute(cqlQuery).FirstOrDefault();


                if (result != null)
                {
                    int numRoomRev = result.GetValue<int>("numroomrev");
                    LocalDate a = result.GetValue<LocalDate>("fechacheckin");
                    if (a==null)
                    {
                        if (fechacheckin == result.GetValue<LocalDate>("fechaentrada")){
                        var updateq = $"UPDATE TRIVAGO.RESERVACIONES SET fechaCheckIn='{fechacheckin}' WHERE RevNum={CodRev};";
                        session.Execute(updateq);
                        MessageBox.Show("Reservación confirmada su habitacion es: "+numRoomRev, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         }
                        else
                        {
                            MessageBox.Show("No es posible hacer CheckIn" + numRoomRev, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Check in ya realizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                    // ayudame aqui porfis pipipi

                }

              // pinkus problemas en inicio de sesion pipipip

            }
            catch
            {
                MessageBox.Show("Error en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public List<UserLoginDto> login(String email,String password) {
        //    string query = 
        //        String.Format(Queries.USER_LOGIN, email, password);
        //    session.Execute(query);
        //    IMapper mapper = new Mapper(session);
        //    IEnumerable<UserLoginDto> users = 
        //        mapper.Fetch<UserLoginDto>(query);
        //    return users.ToList();
        //}

        //USUARIOS
        public void CrearUsuario(string email, string NumEmpleado, string lastName, string firstname, string userType,
                                  string birthdate, string street, string neihtborhood, int number,
                                  string tel, string telcasa, string usuarioRegisto, string currentPas, string pasAnt, string pasAnt1, string pasTemp)
        {
            string insertQuery = $"INSERT INTO TRIVAGO.USUARIOS " +
             "( email, employeenumber, lastName, firstName, userType, birthdate, street, neighborhood, number, tel1, tel2, userR, dateTimeR, status, statusPass, currentps, past, past2, temp,intentosInicio) VALUES " +
             $"('{email}', '{NumEmpleado}', '{lastName}', '{firstname}', '{userType}', '{birthdate}', '{street}', '{neihtborhood}', {number}, '{tel}' , '{telcasa}', '{usuarioRegisto}',  toTimestamp(now()), true, false, '{currentPas}', '{pasAnt}', '{pasAnt1}', '{pasTemp}' , 0);";


            session.Execute(insertQuery);
        }

        public void CambiarContraseña(string email, string currentPas, string PassAnt, string PassAnt2, string temp)
        {
            string insertQuery = $"UPDATE TRIVAGO.USUARIOS " +
             $"SET  currentps='{currentPas}', past='{PassAnt}', past2='{PassAnt2}', temp='{temp}', intentosInicio=0, statusPass=false " +
             $"WHERE email='{email}';";


            session.Execute(insertQuery);
        }

        public string RegresaAlgunDato(string email, string nomColumna)
        {
            string strConDato = null;

            try
            {

                var selectStatement = session.Prepare("SELECT * FROM TRIVAGO.USUARIOS WHERE email = ?");
                var boundStatement = selectStatement.Bind(email);
                var result = session.Execute(boundStatement);

                var row = result.FirstOrDefault();

                if (row != null)
                {
                    strConDato = row.GetValue<string>(nomColumna);
                }
                return strConDato;
            }
            catch
            {
                MessageBox.Show("Error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return strConDato;
            }
        }
        public void EliminarUsuario(string email)
        {
            string insertQuery = $"INSERT INTO TRIVAGO.USUARIOS " +
             "( email,  status) VALUES " +
             $"('{email}', false );";

            MessageBox.Show("Eliminado correctamente!", "Ok! :)", MessageBoxButtons.OK, MessageBoxIcon.Information);

            session.Execute(insertQuery);
        }

        public List<User> SelectTodosUsuarios()
        {
            string insertQuery = $"SELECT * FROM TRIVAGO.USUARIOS; ";
            session.Execute(insertQuery);

            IMapper mapper = new Mapper(session);
            IEnumerable<User> users =
                mapper.Fetch<User>(insertQuery);

            return users.ToList();
        }


        public string StringRandom()
        {
            Random res = new Random();

            // String of alphabets  
            String str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!$%&/=?¡¿";
            int size = 10;

            // Initializing the empty string 
            String ran = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly 
                int x = res.Next(61);

                // Appending the character at the  
                // index to the random string. 
                ran = ran + str[x];
            }

            return ran;

        }

        //RESERVACIONES
        public List<Hotel> hoteles(string masquery = "")
        {
            string query =
                String.Format("SELECT country, state, city, namehotel, id, floorNum, roomNum, street, number, neighborhood,quantitytypes, roomtype,start from TRIVAGO.HOTELES" + masquery + ";");
            session.Execute(query);
            IMapper mapper = new Mapper(session);

            IEnumerable<Hotel> hoteles = mapper.Fetch<Hotel>(query);


            return hoteles.ToList();
        }
        public List<Reservacion> habitacionesReservadas(string masquery = "")
        {
            string query =
                String.Format("SELECT numRoomRev, fechaEntrada, fechaSalida, cityRev, hotelRev from TRIVAGO.RESERVACIONES" + masquery + ";");
            session.Execute(query);
            IMapper mapper = new Mapper(session);
            IEnumerable<Reservacion> numHabitaciones = mapper.Fetch<Reservacion>(query);
            return numHabitaciones.ToList();
        }
        public List<Reservacion> Reservaciones(string masquery = "")
        {
            string query =
                String.Format("SELECT RevNum, numRoomRev, fechaEntrada, fechaSalida,paisRev, cityRev, hotelRev,LastNameRev, rfcRev, " +
                "emailCli, roomTypeRev, amenities, metodoPago, AnticipoRev, maxPeopleRev, PeopleInsideREV, fechaCheckIn, " +
                "fechaCheckOut, userR,dateTimeR, totalRev from TRIVAGO.RESERVACIONES" + masquery + ";");
            session.Execute(query);
            IMapper mapper = new Mapper(session);
            IEnumerable<Reservacion> numHabitaciones = mapper.Fetch<Reservacion>(query);
            return numHabitaciones.ToList();
        }
        public List<Habitacion> habitaciones(string masquery = "")
        {
            string query =
                String.Format("SELECT hotel, roomNum, price, type, amenities, bedNum, bedType, maxPeople, level FROM TRIVAGO.HABITACIONES where status=true" + masquery + ";");
            session.Execute(query);
            IMapper mapper = new Mapper(session);
            IEnumerable<Habitacion> numHabitaciones = mapper.Fetch<Habitacion>(query);
            return numHabitaciones.ToList();
        }
        public List<Cliente> clientes(string masquery = "")
        {
            try
            {
            string query =
                String.Format("SELECT rfc, lastName, firstName, emailCli FROM TRIVAGO.CLIENT" + masquery + ";");
            session.Execute(query);
            IMapper mapper = new Mapper(session);
            IEnumerable<Cliente> clienteslist = mapper.Fetch<Cliente>(query);
            return clienteslist.ToList();
            }
            catch
            {
                return null;
            }
        }
        public void InsertarReservacion(Reservacion reservacion)
        {
            Guid idRes = Guid.NewGuid();
            historial = idRes.ToString();
            string query =
             $"INSERT INTO RESERVACIONES(RevNum, numRoomRev, LastNameRev, rfcRev, emailCli, paisRev,cityRev, hotelRev, roomTypeRev, " +
             $"amenities, AnticipoRev, maxPeopleRev, PeopleInsideREV, fechaEntrada, fechaSalida, RevNumStatus, userR, dateTimeR, metodoPago, totalRev) " +
             $"VALUES( {idRes}, {reservacion.numRoomRev}, '{reservacion.lastNameRev}', '{reservacion.rfcRev}', '{reservacion.emailCli}','{reservacion.paisRev}', '{reservacion.cityRev}', '{reservacion.hotelRev}', " +
             $"'{reservacion.roomTypeRev}', ?, {reservacion.AnticipoRev}, {reservacion.maxPeopleRev}, {reservacion.PeopleInsideREV}, '{reservacion.fechaEntrada}', " +
             $"'{reservacion.fechaSalida}', {reservacion.RevNumStatus}, '{reservacion.userR}', toTimeStamp(now()), '{reservacion.metodoPago}', {reservacion.totalRev});";


            var amenitiesList = new List<string>(reservacion.amenities);

            // Create a prepared statement
            var preparedStatement = session.Prepare(query);

            // Bind the parameters and execute the query
            session.Execute(preparedStatement.Bind(amenitiesList));
        }
        public void InsertarCancelacion(Reservacion reservacion)
        {
            string query =
             $"INSERT INTO Cancelaciones(RevCodigoC, fechaCancel, reembolso, fechaCheckIn, userR, dateTimeR)" +
             $"VALUES({reservacion.RevNum}, toDate(Now()), true, '{reservacion.fechaEntrada}', '{reservacion.userR}', toTimeStamp(now()));";


            // Bind the parameters and execute the query
            session.Execute(query);
        }
        public List<Cancelacion> SeleccionarCancelaciones()
        {
            string query =
               String.Format("SELECT RevCodigoC FROM TRIVAGO.Cancelaciones" + ";");
            session.Execute(query);
            IMapper mapper = new Mapper(session);
            IEnumerable<Cancelacion> clienteslist = mapper.Fetch<Cancelacion>(query);
            return clienteslist.ToList();

        }
    }
}
