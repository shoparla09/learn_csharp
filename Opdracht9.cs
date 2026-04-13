using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_csharp
{
    internal class Opdracht9
    {   
        public class Weapon
        {
            private string Name;
            private int Damage;

            public Weapon(string Name, int Damage)
            {
                this.Name = Name;
                this.Damage = Damage;
            }

            public void showstats()
            {
                Console.WriteLine($"{this.Name} doet {Damage} damage");
                Console.WriteLine();
            }

            public void UpdgradeItem(int DamageToAdd)
            {
                this.Damage = this.Damage + DamageToAdd;
            }
        }
        public void Start()
        {
            Weapon weapon = new Weapon("Goede pricker", 10);
            weapon.showstats();

            Weapon glock = new Weapon("Glock", 5);
            Weapon spear = new Weapon("Spear", 3);

            Console.WriteLine("before upgrade");    // TODO scrie tu ceva in olandeza aici
            glock.showstats();
            spear.showstats();

            glock.UpdgradeItem(3);
            spear.UpdgradeItem(5);
            Console.WriteLine("post upgrade");      // TODO scrie tu ceva in olandeza aici
            glock.showstats();
            spear.showstats();

        }
    }
}
