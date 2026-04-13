using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace learn_csharp
{
    internal class Opdracht3
    {
        public void Start()
        {
            
            Console.Write("Wat is het weer?");
            string weer = Console.ReadLine();

            Console.Write("Wat is het temperatuur?");
            string temperatuur = Console.ReadLine();

            if (!Int32.TryParse(temperatuur, out int val))
            {
                while (!Int32.TryParse(temperatuur, out val))
                {
                    Console.Write("Wat is het temperatuur?:  "); 
                    temperatuur = Console.ReadLine();
                }
            }

            if (weer == "zonnig")
                if (val >= 20)
                    Console.WriteLine("Je hebt geen jas nodig vandaag geniet lekker van de zon!");
                else if (val <= 19 && val >= 10)
                    Console.WriteLine("trek een t-shirt aan en geniet van de zon!");
                else
                    Console.WriteLine("Het is koud");

            if (weer == "bewolkt" && val  >= 15)
                Console.WriteLine("trek een jas aan, het kan koud worden.");

            if (weer == "regen" && val <= 15)
                Console.WriteLine("trek een kapisjon op, het regent!");


        }
    }
}