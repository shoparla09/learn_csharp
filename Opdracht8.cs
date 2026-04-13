using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace learn_csharp
{
    internal class Opdracht8
    {

        public class karakter
        {


            private string _Name = "player1";
            private int _level = 5;
            private int lives = 3;
            public karakter(string _Name, int _level, int lives = 3)
            {
                this._Name = _Name;
                this._level = _level;
                this.lives = lives;
            }

            public void showstats()
            {
                Console.WriteLine($"Name: {this._Name} ==== Level: {this._level} === Lives: {this.lives}");
            }
        }
        public void Start()
        {
            karakter kar1 = new karakter("static_player", 5);
            kar1.showstats();

            Console.WriteLine();

            List<karakter> kars = new List<karakter>();
            kars.Add(new karakter("loop_player1", 5, 2));
            kars.Add(new karakter("loop_player2", 25, 3));
            kars.Add(new karakter("loop_player3", 60));

            foreach(karakter kar in kars)
            {
                kar.showstats();
            }
        }
    }
}


