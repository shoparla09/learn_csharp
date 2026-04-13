using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdracht10
    {
        public void Start()
        {
            Console.Write("Welke woord: ");
            string woord = Console.ReadLine();

            char[] reversed = woord.ToCharArray();
            Array.Reverse(reversed);
            
            string rev_woord = new string(reversed);

            Console.WriteLine($"Reverse woord: {rev_woord}");
            
            if (woord == rev_woord)
            {
                Console.WriteLine("Deze woord is een palindrom");
            }
            else
            {
                Console.WriteLine("Deze woord is niet een palindrom");
            }
        }
    }
}
