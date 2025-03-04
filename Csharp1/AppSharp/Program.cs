using System;
using AppSharp.Models;
using AppSharp.Services;
using AppSharp.Controllers;

class Program
{
    static void Main() {
        Console.WriteLine("🔹 Application C# en exécution...");

        // Initialisation du contrôleur et du service
        var personController = new PersonController();
        var calculService = new CalculService();

        // Création d'une personne
        var person = personController.CreerPersonne("Alice", 30);
        Console.WriteLine($"👤 Personne créée : {person}");

        // Exécution d'un calcul
        int somme = calculService.Additionner(5, 10);
        Console.WriteLine($"➕ Somme : {somme}");
    }
}
