// See https://aka.ms/new-console-template for more information
using HealthSystem;
using System;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");




List<IUser> users = new List<IUser>();

users.Add(new Patient { FullName = "John Doe", PersonalNumber = "123456-7890", Email = "john@health.com", Phone = "0701234567", Username = "john", Password = "1234" });
users.Add(new Patient { FullName = "Jane Smith", PersonalNumber = "987654-3210", Email = "jane@health.com", Phone = "0707654321", Username = "jane", Password = "abcd" });

