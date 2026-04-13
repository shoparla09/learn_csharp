using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdracht7
    {
        public void Start()
        {

            Random random = new Random();
            int[] found = new int[7];
           
            int[] aantalkeer = new int[100];
          
            for (int i = 0; i < aantalkeer.Length; i++)
                
            {

                aantalkeer[i] = random.Next(1, 7);
                Console.WriteLine(aantalkeer[i]);
            }

            foreach (int i in aantalkeer)
            {   
                found[i]++;
              
            }
            for (int i = 1; i < found.Length; i++)
            {
                int grootsteaantal = 0;
                if (found[i] > grootsteaantal)
                {
                    grootsteaantal = found[i];
                    double percentage = (double)found[i] / aantalkeer.Length * 100;

                    Console.WriteLine(" ");
                    Console.WriteLine($"number {i} appears {found[i]} times");
                    Console.WriteLine($"het percentage van {i} is {percentage}%");
                    Console.WriteLine($"De meeste aantal worpen waren voor het getal: { grootsteaantal}");
                }
            }
        }
    }
}