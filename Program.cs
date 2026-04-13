using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Program
    {
        
    public void NaamenLeeftijd();
        static void Main()
        {
            Console.WriteLine("wat is jouw naam?");
            string naam = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("wat is jouw leeftijd?");
            string leeftijd = Console.ReadLine();

            Console.WriteLine("Hoi " + naam + ". Jij bent " + leeftijd + " jaar oud!");

        

}

        