using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdracht1
    {
        public void Start()
        {
            Console.WriteLine("Wat is jouw naam?");
            string naam = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Wat is jouw leeftijd?");
            string leeftijd = Console.ReadLine();
            int leeftijdInGetal;
            bool isGetal = int.TryParse(leeftijd, out leeftijdInGetal);
            if (isGetal)
            {
                Console.WriteLine("Hoi " + naam + ", Jij bent " + leeftijd + " jaar oud!"); Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hoi " + naam + ", Jij hebt geen geldige leeftijd opgegeven.");
            }
        }
    }
}
