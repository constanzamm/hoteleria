using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoteleria.Util
{
    internal class Queries
    {
        private Queries() { }

        static public string USER_LOGIN =
            "SELECT email, password, employeeNumber, status, userType" +
            " FROM USERS " +
            "WHERE email = '{0}' AND password = '{1}'";

        static public string GET_CLIENTS =
            "SELECT FirstName, LastName, addressCLI, rfc, emailCli, contactCLI," +
            "reference, birthdateCLI, civilStatus, registroCLI, status FROM CLIENT;";

        static public string INSERT_CLIENT =
            "INSERT INTO CLIENT(FirstName, LastName, addressCLI, rfc, emailCli, contactCLI, reference, birthdateCLI, civilStatus, registroCLI, status) " +
            "VALUES('{0}', '{1}', {street: '{2}', neighborhood: '{3}', number: {4}}, '{5}', {'{6}', '{7}'}, {8}, '{9}', '{10}', '{11}', {userR: '{12}', datetimeR: toTimestamp(now())}, 1);";

        static public string DELETE_CLIENT =
            "UPDATE CLIENT SET status = 0 WHERE emailCli = '{0}'";
        static public string GET_HOTELES =
    "SELECT country AS Pais, state AS Estado, city AS Ciudad, namehotel AS Nombre," +
    "address AS Domicilio, floornum AS Numero_Pisos, roomnum AS Numero_Habitaciones" +
    "from db_aavd.HOTELES;";
        static public string GETHOTELES =
            "SELECT country, state, city, namehotel, floorNum, roomNum, street, number, neighborhood from db_aavd.HOTELES";
        static public string HABITACIONES_RESERVADAS =
            "SELECT numRoomRev, fechaEntrada, fechaSalida, cityRev, hotelRev from db_aavd.RESERVACIONES";
        static public string HABITACIONES =
            "SELECT hotel, roomNum, price FROM db_aavd.HABITACIONES where status=true";
        static public string CLIENTES =
            "SELECT rfc, lastName, firstName, emailCli FROM db_aavd.CLIENT";
        static public string INSERTAR_RESERVACION =
            "INSERT INTO db_aavd.RESERVACIONES(RevNum, numRoomRev, LastNameRev, rfcRev, " +
            "emailCli, cityRev, hotelRev, roomTypeRev, amenities, AnticipoRev, maxPeopleRev, " +
            "PeopleInsideREV, fechaEntrada, fechaSalida, RevNumStatus, registroRev) " +
            "VALUES(UUID(), {0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, {8}, {9},{10},'{11}'," +
            "'{12}', {13}, {14});";

    }
}
