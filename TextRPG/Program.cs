using System;
using System.Collections.Generic;

namespace TextRPG 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var creature1 = new Creature("test", 100);
            Console.WriteLine(creature1.CurrentHitPoints);
            creature1.TakeDamage(20);
            Console.WriteLine(creature1.CurrentHitPoints);
            Console.WriteLine(creature1.BaseHitPoints);
            creature1.Heal(20);
            Console.WriteLine(creature1.CurrentHitPoints);
            Console.WriteLine(creature1.BaseHitPoints); 
        }
    }
}