
using Healthcaresystem;
using System;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

// Create user list
List<Personal> users = new List<Personal>();

users.Add(new Personal("john", "1234", "John Doe"));
users.Add(new Personal("jane", "abcd", "Jane Smith"));

Personal active_user = null;
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

        foreach (Personal user in users)
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
        Console.WriteLine("Welcome, " + active_user.FullName + "!");

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

