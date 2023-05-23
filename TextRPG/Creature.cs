using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Creature
    {
        public int ID { get; }
        public string Species { get; }
        public int BaseHitPoints { get; }
        public int CurrentHitPoints { get; set; }
        
        private static int idSeed = 0;


        public Creature(string species, int basehitPoints)
        {
            Species = species;
            ID = idSeed++;
            BaseHitPoints = basehitPoints;
            CurrentHitPoints = basehitPoints;
        }

        public void TakeDamage(int damage)
        {
            if(damage > 0)
            {
                if(damage > CurrentHitPoints)
                {
                    CurrentHitPoints = 0;
                }
                else
                {
                    CurrentHitPoints -= damage;
                }
            }
            else
            {
                Console.WriteLine("Damage cannot be negative");
            }
        }

       /* public void Heal(int healAmount)
        {
            if(healAmount < HitPoints)
            {
                HitPoints += healAmount;
            }
        }*/

       
    }
}
