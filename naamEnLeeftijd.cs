using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp.naamEnLeeftijd
{
    internal class naamEnLeeftijd
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Wat is jouw naam?");
            string naam = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Wat is jouw leeftijd?");
            string leeftijd = Console.ReadLine();

            //if (leeftijd.i)
            //    {

                Console.WriteLine("Hoi " + naam + ". Jij bent " + leeftijd + " jaar oud!"); Console.ReadLine();
            //}
            //else { 
            //    Console.WriteLine("Hoi " + naam + ". Jij hebt geen geldige leeftijd opgegeven.");
            //}
        }
    }
}
