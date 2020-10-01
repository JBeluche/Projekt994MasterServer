using Projekt994MasterServer.Models;
using System.Data;
using System.Web.Http;

namespace Projekt994MasterServer.Controllers
{
    public class HostController : ApiController
    {
        // GET: api/Host
        public DataTable Get()
        {
            DatabaseInterface DB = new DatabaseInterface();
            return DB.GetAllServers();
        }

        // GET: api/Host/5
        public ServerData Get(int id)
        {

            ServerData Data = new ServerData();

            return Data;
        }

        // POST: api/Host
        public int Post(ServerData Data)
        {
            //Data.ServerName = "This is a test";
            DatabaseInterface DB = new DatabaseInterface();
            return DB.PostData(Data);
        }

        // PUT: api/Host/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Host/5
        public void Delete(int id)
        {
            DatabaseInterface DB = new DatabaseInterface();
            DB.DeleteData(id);
        }
    }
}
