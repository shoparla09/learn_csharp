using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdracht4
    {
        public void Start()
        {
            Console.WriteLine("wat is jouw geboortedatum? ");
            int geboortedatum = Convert.ToInt32(Console.ReadLine());

            int leeftijd = f_leeftijd(geboortedatum);

            Console.WriteLine("je bent " + leeftijd + " jaar oud.");

            if (canVote(leeftijd))
                Console.WriteLine("persoon is toegestaan om te stemmen");
            else
                Console.WriteLine("persoon is nog niet toegestaan om te stemmen");   

        
        }
        int f_leeftijd(int geboortedatum)
        {
            int currentJaar = DateTime.Now.Year;
            int leeftijd = currentJaar - geboortedatum;
            return leeftijd;
        }

        bool canVote(int leeftijd)
        {
            if (leeftijd >= 18)
                return true;
            else
                return false;
        }
    }
}
