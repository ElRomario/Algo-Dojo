using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Situation
{
    public class Weapon
    {
        public  int Damage { get; }
        public int Interval { get; }
        public string Name { get; } 
        
        public Weapon(int _damage, int _interval, string _name) { Damage = _damage; Interval = _interval; Name = _name;}
        public void PrintWeapon()
        {
            Console.WriteLine($"Weapon name: {Name}\n Damage: {Damage}\n Interval: {Interval}"); 
        }
    }
}
