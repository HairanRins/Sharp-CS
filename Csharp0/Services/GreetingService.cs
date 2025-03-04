namespace Csharp0.Services
{
    public class GreetingService
    {
        public string GetGreeting(string name) {
            return $"Bonjour, {name} ! Bienvenue dans notre application.";
        }
    }
}