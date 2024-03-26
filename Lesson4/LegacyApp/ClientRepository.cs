﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace LegacyApp
{
    /// <summary>
    /// This class stores clients' data and allows to access it. It implements IClientRepository interface to
    /// make program more scalable and modular.
    /// </summary>
    public class ClientRepository
    {
        /// <summary>
        /// This collection is used to simulate remote database
        /// </summary>
        private readonly Dictionary<int, Client> _database;
        
        public ClientRepository()
        {
            _database = new Dictionary<int, Client>()
            {
                {1, new Client{ClientId = 1, Name = "Kowalski", Address = "Warszawa, Złota 12", Email = "kowalski@wp.pl", Type = "NormalClient"}},
                {2, new Client{ClientId = 2, Name = "Malewski", Address = "Warszawa, Koszykowa 86", Email = "malewski@gmail.pl", Type = "VeryImportantClient"}},
                {3, new Client{ClientId = 3, Name = "Smith", Address = "Warszawa, Kolorowa 22", Email = "smith@gmail.pl", Type = "ImportantClient"}},
                {4, new Client{ClientId = 4, Name = "Doe", Address = "Warszawa, Koszykowa 32", Email = "doe@gmail.pl", Type = "ImportantClient"}},
                {5, new Client{ClientId = 5, Name = "Kwiatkowski", Address = "Warszawa, Złota 52", Email = "kwiatkowski@wp.pl", Type = "NormalClient"}},
                {6, new Client{ClientId = 6, Name = "Andrzejewicz", Address = "Warszawa, Koszykowa 52", Email = "andrzejewicz@wp.pl", Type = "NormalClient"}}
            };
        }

        /// <summary>
        /// Simulating fetching a client from remote database
        /// </summary>
        /// <returns>Returning client object</returns>
        public Client GetById(int clientId)
        {
            if (_database.ContainsKey(clientId))
                return _database[clientId];

            throw new ArgumentException($"Client with id {clientId} does not exist in database");
        }
    }
}