using System;
using System.IO;

class PoorLoggingPractice
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter username:");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string password = Console.ReadLine(); // Dette er en meget dårlig praksis!

        // Simulering af brugervalidering (ikke en reel validering)
        if (username != "" && password != "")
        {
            Log($"User login attempt: {username} with password {password}"); // Meget dårlig praksis!

            // Antag, at valideringen lykkes
            Log($"User {username} logged in successfully.");

            // Simulerer yderligere brugerhandling
            Log($"User {username} performed action A.");
            Log($"User {username} performed action B.");
            Log($"User {username} performed action C."); // Overlogging
        }
        else
        {
            Log("Login attempt failed due to empty username or password."); // Mangler niveauinddeling
        }
    }

    static void Log(string message)
    {
        // Ustruktureret og simpelt logformat
        File.AppendAllText("applog.txt", $"{DateTime.Now}: {message}\n");
    }
}
