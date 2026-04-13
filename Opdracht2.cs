using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace learn_csharp
{
    internal partial class Opdracht2
    {
        public void Start() {

            //string choice1 = "keuken, woonkamer, trap";
            //string choice2 = "slaapkamer, gang, badkamer";
            //string keuze = "yourchoice";
            //int userchoice;

            //Console.ReadLine();

            //if(userchoice == 1)
            //{
            //    Console.WriteLine(choice1);
            //}
            //else
            //    Console.WriteLine(choice2);

            string left;
            string right;
            left = "left";
            right = "right";
            string direction = right;

            Console.WriteLine("which direction do you want to go? " + direction);

            //     bool left;
            // left = false;
            // bool.TryParse("left", out bool result);



            if (direction == left)
            {
                Console.WriteLine("living room -> hallway -> bathroom");
            }
            else
            {
                Console.WriteLine("living room -> stairs -> bedroom");
            }
        }
    }
}
