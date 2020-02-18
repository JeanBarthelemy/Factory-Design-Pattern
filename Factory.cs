using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Design_Pattern
{
    public class Factory
    {
        public static President CreatePresident(string characterTrait)
        {
            if (characterTrait == "Vénal")
            {
                President president = new PresidentLREM();
                return president;
            }
            else if (characterTrait == "Indécis")
            {
                President president = new PresidentDuCentre();
                
                return president;
            }
            else if (characterTrait == "Fou")
            {
                President president = new PresidentExtremeGauche();
                Console.WriteLine(president.Slogan);
                return president;
            }
            else if (characterTrait == "Végétarien")
            {
                President president = new PresidentEcologiste();
                Console.WriteLine(president.Slogan);
                return president;
            }
            else if (characterTrait == "Profiteur")
            {
                President president = new PresidentDeGauche();
                Console.WriteLine(president.Slogan);
                return president;
            }
            else if (characterTrait == "Psychopathe")
            {
                President president = new PresidentDeDroite();
                Console.WriteLine(president.Slogan);
                return president;
            }
            else if (characterTrait == "Xénophobe")
            {
                President president = new PresidentExtremeDroite();
                Console.WriteLine(president.Slogan);
                return president;
            }
            else
            {
                Console.WriteLine("This character trait is not in the list, please try again with one on the list.");
                throw new ArgumentException("This character trait is not in the list, please try again with one on the list");
            }
            
        }

    }
}
