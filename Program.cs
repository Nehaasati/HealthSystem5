// See https://aka.ms/new-console-template for more information
using HealthSystem;
using System;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");




List<IUser> users = new List<IUser>();

users.Add(new Patient { FullName = "John Doe", PersonalNumber = "123456-7890", Email = "john@health.com", Phone = "0701234567", Username = "john", Password = "1234" });
users.Add(new Patient { FullName = "Jane Smith", PersonalNumber = "987654-3210", Email = "jane@health.com", Phone = "0707654321", Username = "jane", Password = "abcd" });

IUser active_user = null;
bool running = true;

while (running)
{
    Console.Clear();

    if (active_user == null)
    {
        Console.WriteLine("=== HealthCare System Login ===");
        Console.Write("Username: ");
        string username = Console.ReadLine() ?? "";

        Console.Write("Password: ");
        string password = Console.ReadLine() ?? "";

        foreach (IUser user in users)
        {
            if (user.TryLogin(username, password))
            {
                active_user = user;
                break;
            }
        }

        if (active_user == null)
        {
            Console.WriteLine("Invalid username or password. Press any key to try again.");
            Console.ReadKey();
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("=== HealthCare System ===");

        switch (active_user.GetRole())
        {
            case Role.Patient:
                Console.WriteLine("Welcome, Patient!");
                ((Patient)active_user).DisplayInfo();
                break;

            
        }

        Console.WriteLine();
        Console.WriteLine("Type 'logout' to log out or 'exit' to quit the system.");
        string input = Console.ReadLine() ?? "";

        switch (input.ToLower())
        {
            case "logout":
                active_user = null;
                break;
            case "exit":
                running = false;
                break;
        }
    }
}