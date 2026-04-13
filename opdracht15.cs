using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class opdracht15
    {
            private int _leeftijd;
            public int leeftijd
            {
                get { return _leeftijd; }
                set
                {
                if (value >= 0)
                {

                    _leeftijd = value;
                    Console.WriteLine(value);
                
                }
            }
        }
    }
}


