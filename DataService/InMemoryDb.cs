using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebChat.Models;

namespace WebChat.DataService
{
    public class InMemoryDb
    {
        private readonly ConcurrentDictionary<string,UserConnection> _connections = new ();

        public ConcurrentDictionary<string,UserConnection> connections => _connections;
    }
}