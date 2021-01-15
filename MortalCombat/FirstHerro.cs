using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    class FirstHerro : HerroTemplate
    {
        int percentUlta;
        public override event EventHandler<ResultBatle> Dead;
        public override event EventHandler<ResultBatle> Victory;
        public event EventHandler<AbilityEventArgs> Ulta;

        public static int countVictory = 0;
        public static int countDeath = 0;
        
        public FirstHerro(string name, int helth, int minDamage, int maxDamage, int percentUlta) : base(name, helth, minDamage, maxDamage)
        {
            this.percentUlta = percentUlta;
        }

        public FirstHerro() : base()
        {
        }

        public override void Attack(HerroTemplate otherHerro)
        {
            GenerateAttack(MinDamage, MaxDamage);
            base.Attack(otherHerro);
        }
        public override void GenerateAttack(int min, int max)
        {
            base.GenerateAttack(min, max);
            Random random = new Random(DateTime.Now.Millisecond);
            if (random.Next(0, 101) <= percentUlta)
            {
                Console.WriteLine(Damage);
                Damage *= 2;
                Ulta(this, new AbilityEventArgs($"Ульта {Damage}"));
            }
        }

        public void CheckVictoryORDeath(HerroTemplate other)
        {
            if (Helth <= 0)
            {
                Dead?.Invoke(this, new ResultBatle($"герой {Name} побежден"));
                countDeath++;
            }
            if(other.Helth<=0)
            {
                Victory?.Invoke(this, new ResultBatle($"герой {Name} одержал победу"));
                countVictory++;
            }
        }

        public override string ToString()
        {
            return $"Герой {Name} имеет {Helth} здоровья и {Damage} силу";
        }
        
    }
}
