using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdracht11
    {
        public void Start()
        {
            var random = new Random();
            int num1 = random.Next(1001);

            Console.WriteLine(num1);
        }
    }
}
