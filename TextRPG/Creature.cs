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
        public int BaseIntelligence { get; }
        public int CurrentIntelligence { get; set; }
        public int BaseWisdom { get; }
        public int CurrentWisdom { get; set; }
        public int BaseCharisma { get; }
        public int CurrentCharisma { get; set; }
        public int BaseStrength { get; }
        public int CurrentStrength { get; set; }
        public int BaseDexterity { get; }
        public int CurrentDexterity { get; set; }
        public int BaseConstitution { get; }
        public int CurrentConstitution { get; set; }

        private static int idSeed = 0;


        public Creature(string species, int basehitPoints, 
            int baseInt, int baseWis, int baseCha, 
            int baseStr, int baseDex, int baseCon)
        {
            Species = species;
            ID = idSeed++;
            BaseHitPoints = basehitPoints;
            CurrentHitPoints = basehitPoints;
            BaseIntelligence = baseInt;
            CurrentIntelligence = baseInt;
            BaseWisdom = baseWis;
            CurrentWisdom = baseWis;
            BaseCharisma = baseCha;
            BaseStrength = baseStr;
            CurrentStrength = baseStr;
            BaseDexterity = baseDex;
            CurrentDexterity = baseDex;
            BaseConstitution = baseCon;
            CurrentConstitution = baseCon;
            
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

        public void Heal(int healAmount)
        {
          if(healAmount > 0) 
            {
                if(healAmount > BaseHitPoints)
                {
                    CurrentHitPoints = BaseHitPoints;
                }
                else
                {
                    CurrentHitPoints += healAmount;
                }
            }
            else
            {
                Console.WriteLine("Cannot heal negative amount!");
            }
        }

       
    }
}
