using Projekt994MasterServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projekt994MasterServer.Controllers
{
    public class HostController : ApiController
    {
        // GET: api/Host
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Host/5
        public ServerData Get(int id)
        {

            ServerData Data = new ServerData();

            return Data;
        }

        // POST: api/Host
        public void Post(ServerData Data)
        {
            //Data.ServerName = "This is a test";
            DatabaseInterface DB = new DatabaseInterface();
            DB.PostData(Data);
        }

        // PUT: api/Host/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Host/5
        public void Delete(int id)
        {
        }
    }
}
