using System;

namespace Factory_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a character trait from the list : Vénal, Indécis, Fou, Végétarien, Profiteur, Psychopathe, Xénophobe");
            string characterTrait = Console.ReadLine();
            President president = Factory.CreatePresident(characterTrait);
            Console.WriteLine($"A new president is created : {president.GetType().Name}, here's his slogan : \"{president.Slogan}\"");
        }
    }
}
