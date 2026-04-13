using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdracht5
    {
        public void Start()
        {
            int tafel;
        

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("5 * " + i + " = " + 5*i );

            }
            Console.Write("voer een nummer in: ");


            tafel= Convert.ToInt32(Console.ReadLine());

            for (int k = 1; k <= 10; k++ )
            {
                Console.WriteLine( tafel + " * " + k + " = " + tafel * k);
                }
            }
        }
    }






