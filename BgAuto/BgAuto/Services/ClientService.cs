using BgAuto.Abstraction;
using BgAuto.Data;
using BgAuto.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BgAuto.Services
{
    public class ClientService: IClientService
    {
        private readonly ApplicationDbContext context;

        public ClientService(ApplicationDbContext _context)
        {
            this.context = _context;
        }
        public bool CreateClient(string phone, string address, string userId)
        {
            if (context.Clients.Any(x => x.UserId == userId))
            {
                throw new InvalidOperationException("User already exist.");
            }

            Client client = new Client
            {
                Address = address,
                UserId = userId,
                Phone = phone
            };
            context.Clients.Add(client);
            return context.SaveChanges() != 0;
        }

        public Client GetClient(string id)
        {
            var client = context.Clients.FirstOrDefault(x => x.UserId == id);
            client.User = context.Users.Find(client.UserId);

            return client;
        }
        public List<Client> GetClients()
        {
            var list = context.Clients.ToList();

            foreach (var item in list)
            {
                if (item.User == null)
                {
                    item.User = context.Users.Find(item.UserId);
                }
            }
            return list;
        }

    }
}
