using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    public class SqliteDataAccess
    {
        public static List<Room> LoadRooms()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectString()))
            {
                var output = cnn.Query<Room>("select * from Room", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Client> LoadClients()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectString()))
            {
                var output = cnn.Query<Client>("select * from Client", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Reservation> LoadReservations()
        {
            
            List<Reservation> reservations = new List<Reservation>();

            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectString()))
            {
                connection.Open();

                string query = "SELECT * FROM Reservation";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int reservationID = reader.GetInt32(0);
                            int clientID = reader.GetInt32(1);
                            int roomNumber = reader.GetInt32(2);
                            DateTime checkInDate = DateTime.Parse(reader.GetString(3));
                            DateTime checkOutDate = DateTime.Parse(reader.GetString(4));

                            reservations.Add(new Reservation(reservationID, clientID, roomNumber, checkInDate, checkOutDate));
                        }

                        return reservations;
                    }
                }
            }

            /*
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectString()))
            {
                var output = cnn.Query<Reservation>("select * from Client", new DynamicParameters());
                return output.ToList();
            }
            */
        }

        public static bool AddRoom(int roomNumber, string roomType, string roomPhone, string roomStatus)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "insert into Room (RoomNumber, RoomType, RoomPhone, RoomStatus) values (@RoomNumber, @RoomType, @RoomPhone, @RoomStatus)";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@RoomNumber", roomNumber));
            command.Parameters.Add(new SQLiteParameter("@RoomType", roomType));
            command.Parameters.Add(new SQLiteParameter("@RoomPhone", roomPhone));
            command.Parameters.Add(new SQLiteParameter("@RoomStatus", roomStatus));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }

        public static bool AddClient(int clientID, string clientFirstName, string clientLastName, string clientAddress, string clientPhone, string clientEmail)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "insert into Client (ClientID, ClientFirstName, ClientLastName, ClientAddress, ClientPhone, ClientEmail) values (@ClientID, @ClientFirstName, @ClientLastName, @ClientAddress, @ClientPhone, @ClientEmail)";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@ClientID", clientID));
            command.Parameters.Add(new SQLiteParameter("@ClientFirstName", clientFirstName));
            command.Parameters.Add(new SQLiteParameter("@ClientLastName", clientLastName));
            command.Parameters.Add(new SQLiteParameter("@ClientAddress", clientAddress));
            command.Parameters.Add(new SQLiteParameter("@ClientPhone", clientPhone));
            command.Parameters.Add(new SQLiteParameter("@ClientEmail", clientEmail));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }

        public static bool AddReservation(int reservationID, int clientID, int roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "insert into Reservation (ReservationID, ClientID, RoomNumber, CheckInDate, CheckOutDate) values (@ReservationID, @ClientID, @RoomNumber, @CheckInDate, @CheckOutDate)";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@ReservationID", reservationID));
            command.Parameters.Add(new SQLiteParameter("@ClientID", clientID));
            command.Parameters.Add(new SQLiteParameter("@RoomNumber", roomNumber));
            command.Parameters.Add(new SQLiteParameter("@CheckInDate", checkInDate.ToString()));
            command.Parameters.Add(new SQLiteParameter("@CheckOutDate", checkOutDate.ToString()));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }

        public static bool EditRoom(int roomNumber, string roomType, string roomPhone, string roomStatus)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "update Room set RoomType = @RoomType, RoomPhone = @RoomPhone, RoomStatus = @RoomStatus where RoomNumber = @RoomNumber";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@RoomNumber", roomNumber));
            command.Parameters.Add(new SQLiteParameter("@RoomType", roomType));
            command.Parameters.Add(new SQLiteParameter("@RoomPhone", roomPhone));
            command.Parameters.Add(new SQLiteParameter("@RoomStatus", roomStatus));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }
        public static bool EditClient(int clientID, string clientFirstName, string clientLastName, string clientAddress, string clientPhone, string clientEmail)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "update Client set ClientID = @ClientID, ClientFirstName = @ClientFirstName, ClientLastName = @ClientLastName, ClientAddress = @ClientAddress, ClientPhone = @ClientPhone, ClientEmail = @ClientEmail where ClientID = @ClientID";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@ClientID", clientID));
            command.Parameters.Add(new SQLiteParameter("@ClientFirstName", clientFirstName));
            command.Parameters.Add(new SQLiteParameter("@ClientLastName", clientLastName));
            command.Parameters.Add(new SQLiteParameter("@ClientAddress", clientAddress));
            command.Parameters.Add(new SQLiteParameter("@ClientPhone", clientPhone));
            command.Parameters.Add(new SQLiteParameter("@ClientEmail", clientEmail));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }

        public static bool EditReservation(int reservationID, int clientID, int roomNumber, DateTime checkInDate, DateTime checkOutDate)
        {   
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "update Reservation set ReservationID = @ReservationID, ClientID = @ClientID, RoomNumber = @RoomNumber, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@ReservationID", reservationID));
            command.Parameters.Add(new SQLiteParameter("@ClientID", clientID));
            command.Parameters.Add(new SQLiteParameter("@RoomNumber", roomNumber));
            command.Parameters.Add(new SQLiteParameter("@CheckInDate", checkInDate.ToString()));
            command.Parameters.Add(new SQLiteParameter("@CheckOutDate", checkOutDate.ToString()));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }
        public static bool DeleteRoom(int roomNumber)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "delete from Room where RoomNumber = @RoomNumber";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@RoomNumber", roomNumber));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }

        public static bool DeleteClient(int clientID)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "delete from Client where ClientID = @ClientID";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@ClientID", clientID));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }
        public static bool DeleteReservation(int reservationID)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "delete from Reservation where ReservationID = @ReservationID";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@ReservationID", reservationID));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }

        public static DataTable LoadRoomType()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectString()))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable dataTable = new DataTable();
                SQLiteCommand command = new SQLiteCommand("select * from Category", cnn);
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static DataTable LoadRoomIDs()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectString()))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable dataTable = new DataTable();
                SQLiteCommand command = new SQLiteCommand("select * from Room where RoomStatus ='Free'", cnn);
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        // update room status
        public static bool UpdateRoomStatus(int roomNumber, string roomStatus)
        {
            SQLiteConnection cnn = new SQLiteConnection(LoadConnectString());
            string insertQuerry = "update Room set RoomStatus = @RoomStatus where RoomNumber = @RoomNumber";
            SQLiteCommand command = new SQLiteCommand(insertQuerry, cnn);
            command.Parameters.Add(new SQLiteParameter("@RoomNumber", roomNumber));
            command.Parameters.Add(new SQLiteParameter("@RoomStatus", roomStatus));

            cnn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }
        }   

        public static DataTable LoadClientIDs()
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectString()))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                DataTable dataTable = new DataTable();
                SQLiteCommand command = new SQLiteCommand("SELECT ClientID, ClientFirstName || ' ' || ClientLastName AS FullName FROM Client", cnn);
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        private static string LoadConnectString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
            
    }
}
