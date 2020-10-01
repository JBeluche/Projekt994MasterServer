using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Projekt994MasterServer.Models
{
    public class DatabaseInterface
    {
        private MySqlConnection SqlConnection;
        public DatabaseInterface()
        {
            string ConnectionString = "server=127.0.0.1;uid=jbeluche;pwd=Le13$monde;database=projekt994_data;";

            SqlConnection = new MySqlConnection(ConnectionString);
        }

        public int PostData(ServerData Data)
        {
            try
            {

                SqlConnection.Open();

                MySqlCommand Command = new MySqlCommand("AddServerEntry", SqlConnection); 
                Command.CommandType = System.Data.CommandType.StoredProcedure;

                Random Random = new Random();
                int ServerID = Random.Next(1, 2000000000);


                Command.Parameters.AddWithValue("_ServerID", ServerID);
                Command.Parameters.AddWithValue("_IPAddress", Data.IPAddress);
                Command.Parameters.AddWithValue("_ServerName", Data.ServerName);
                Command.Parameters.AddWithValue("_MapName", Data.IPAddress);
                Command.Parameters.AddWithValue("_CurrentPlayers", Data.CurrentPlayers);
                Command.Parameters.AddWithValue("_MaxPlayers", Data.MaxPlayers);

                Command.ExecuteNonQuery();

                SqlConnection.Close();

                return 999;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e);

                return -1;

            }
        }

    }
}