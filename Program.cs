using learn_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdrachts
    {
        public static void Main(string[] args)
        {
            Console.Write("Welke opdracht: ");
            int.TryParse(Console.ReadLine(), out int opt);
            switch (opt)
                {
                    case 1:
                        Opdracht1 opdracht1 = new Opdracht1();
                        opdracht1.Start();
                        break;
                    case 2:
                        Opdracht2 opdracht2 = new Opdracht2();
                        opdracht2.Start();
                        break;
                    case 3:
                        Opdracht3 opdracht3 = new Opdracht3();
                        opdracht3.Start();
                        break;
                    case 4:
                        Opdracht4 opdracht4 = new Opdracht4();
                        opdracht4.Start();
                        break;
                    case 5:
                        Opdracht5 opdracht5 = new Opdracht5();
                        opdracht5.Start();
                        break;
                    case 6:
                        Opdracht6 opdracht6 = new Opdracht6();
                        opdracht6.Start();
                        break;
                    case 7:
                        Opdracht7 opdracht7 = new Opdracht7();
                        opdracht7.Start();
                        break;
                    case 8:
                        Opdracht8 opdracht8 = new Opdracht8();
                        opdracht8.Start();
                        break;
                    case 9:
                        Opdracht9 opdracht9 = new Opdracht9();
                        opdracht9.Start();
                        break;
                    case 10:
                        Opdracht10 opdracht10 = new Opdracht10();
                        opdracht10.Start();
                        break;
                    case 11:
                        Opdracht11 opdracht11 = new Opdracht11();
                        opdracht11.Start();
                        break;
                    case 12:
                        Opdracht12 opdracht12 = new Opdracht12();
                        opdracht12.Start();
                        break;
                    default:
                        Console.WriteLine("Jij heb een fout gemaakt!");
                        break;
                }
            }
        }
    }

