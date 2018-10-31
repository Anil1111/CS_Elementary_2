using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4.Classes
{
    public class Clients
    {
        private List<Client> listClients;

        public Clients()
        {
            ListClients = new List<Client>();
        }

        public List<Client> ListClients { get => listClients; set => listClients = value; }

        public void ShowClients()
        {
            foreach (var client in ListClients)
            {
                client.ShowClient();
            }
        }
    }
}
