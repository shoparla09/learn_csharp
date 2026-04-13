using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdracht6
    {
        public void Start()
        {
            Random random = new Random();
            int number = random.Next(1, 10);
            int guess = 0;
            int aantalpogingen = 1;

            while (guess != number)
            {

                Console.WriteLine("raad een getal tussen 1 en 10");
                bool input = Int32.TryParse(Console.ReadLine(), out guess);

                while (input == false)
                {
                    Console.WriteLine("voer een cijfer in");
                    input = Int32.TryParse(Console.ReadLine(), out guess);
                }

                    {

                        Console.WriteLine("aantal pogingen: " + aantalpogingen);
                        aantalpogingen++;

                        if (guess == number)

                        {
                            Console.WriteLine("gefeliciteerd, je hebt het nummer geraden!");

                        }
                    else if (guess > 10)
                    {
                        Console.WriteLine("voer een geldig getal in");
                    }
                    else if (guess > number)
                        {
                            Console.WriteLine("het getal is te hoog, raad nog een keer.");
                        }
                        
                        else

                            Console.WriteLine("het getal is te klein, raad opnieuw.");
     
                }
            }
        }

    }
}
        
