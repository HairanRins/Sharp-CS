using System;
using Csharp0.Services;

namespace Csharp0
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Bienvenue dans l'application !");

            // Initialisation des services 
            var service = new GreetingService();

            // Appel de la méthode du service
            string message = service.GetGreeting("Utilisateur");
            Console.WriteLine(message);

            Console.WriteLine("Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}
