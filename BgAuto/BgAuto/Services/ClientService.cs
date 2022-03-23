﻿using BgAuto.Abstraction;
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
        public bool CreateClient(string firstName, string lastName, string phone, string address, string userId)
        {
            if (context.Clients.Any(x => x.UserId == userId))
            {
                throw new InvalidOperationException("User already exist.");
            }

            Client client = new Client
            {
                FirstName = firstName,
                LastName = lastName,
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

        public string GetFullName(string clientId)
        {
            var client = context.Clients.Find(clientId);

            if (client == null)
            {
                return null;
            }
            return $"{client.FirstName} {client.LastName}";
        }

        public bool Remove(string clientId)
        {
            var client = context.Clients.Find(clientId);
            var myOrders = context.TestDrives.Where(x => x.CustomerId == client.UserId);

            if (client == null)
            {
                return false;
            }

            foreach (var order in myOrders)
            {
                context.TestDrives.Remove(order);
            }

            var user = context.Users.Find(client.UserId);

            context.Users.Remove(user);
            context.Clients.Remove(client);

            return context.SaveChanges() != 0;
        }

        public bool Update(string id, string firstName, string lastName, string phone, string address)
        {
            return false;
        }
    }
}
