using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt994MasterServer.Models
{
    public class ServerData
    {
        public int ServerID { get; set; }
        public string IPAdress { get; set; }
        public string ServerNAme { get; set; }
        public string MapName { get; set; }
        public int CurrentPlayers { get; set; }
        public int MaxPlayers { get; set; }
    }
}