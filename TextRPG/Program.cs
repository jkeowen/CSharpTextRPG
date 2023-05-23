using System;
using System.Collections.Generic;

namespace TextRPG 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var creature1 = new Creature("test", 59);
            Console.WriteLine(creature1.CurrentHitPoints);
            creature1.TakeDamage(-6);
            Console.WriteLine(creature1.CurrentHitPoints);
           // creature1.Heal(100);
            //Console.WriteLine(creature1.HitPoints);
        }
    }
}