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

        private static string LoadConnectString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
            
    }
}
