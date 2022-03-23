using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Abstraction
{
    public interface IClientService
    {
        public List<Client> GetClients();
        public Client GetClient(string id);
        public bool CreateClient(string firstName, string lastName, string phone, string address, string userId);
        public bool Remove(string clientId);
        public string GetFullName(string clientId);
        public bool Update(string id, string firstName, string lastName, string phone, string address);
    }
}
