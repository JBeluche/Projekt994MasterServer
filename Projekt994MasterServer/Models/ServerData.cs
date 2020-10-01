using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Projekt994MasterServer.Models
{
    public class ServerData
    {
        public int ServerID { get; set; }
        public string IPAddress { get; set; }
        public string ServerNAme { get; set; }
        public string MapName { get; set; }
        public int CurrentPlayers { get; set; }
        public int MaxPlayers { get; set; }

        public void Test()
        {
            string ConnectionString = "server=127.0.0.1;uid=jbeluche;pwd=Le13$monde;database=projekt994_data;";

            MySqlConnection SqlConnection = new MySqlConnection(ConnectionString);

            try
            {
                SqlConnection.Open();

                MySqlCommand Command = new MySqlCommand("AddServerEntry", SqlConnection); ;
                Command.CommandType = System.Data.CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("_ServerID", 5);
                Command.Parameters.AddWithValue("_IPAddress", "107.13.156");
                Command.Parameters.AddWithValue("_ServerName", "Shitland");
                Command.Parameters.AddWithValue("_MapName", "Shitland");
                Command.Parameters.AddWithValue("_CurrentPlayers", 5);
                Command.Parameters.AddWithValue("_MaxPlayers", 50);

                Command.ExecuteNonQuery();

                SqlConnection.Close();
            }
            catch(Exception e)
            {
                Console.Out.WriteLine(e);
            }
        }
    }
}