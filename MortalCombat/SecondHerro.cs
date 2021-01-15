using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    class SecondHerro : HerroTemplate
    {
        int percentUklon;
        public event EventHandler<AbilityEventArgs> Uklon;
        public override event EventHandler<ResultBatle> Dead;
        public override event EventHandler<ResultBatle> Victory;

        public static int countVictory = 0;
        public static int countDeath = 0;

        
        public SecondHerro(string name, int helth, int minDamage, int maxDamage, int percentUklon) : base(name, helth, minDamage, maxDamage)
        {
            this.percentUklon = percentUklon;
            //Damage = GenerateAttack(minDamage, maxDamage);
        }

        public SecondHerro() : base()
        {
        }

        public override void GetDamage(int damage)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            if (random.Next(0, 101) <= percentUklon)
            {
                Uklon(this, new AbilityEventArgs($"Промох"));
            }
            else 
            {
                base.GetDamage(Damage);
            }
        }


        public override void GenerateAttack(int min, int max)
        {
            base.GenerateAttack(MinDamage, MaxDamage);
        }

        public void CheckVictoryORDeath(HerroTemplate other)
        {
            if (Helth <= 0)
            {
                Dead?.Invoke(this, new ResultBatle($"герой {Name} побежден"));
                countDeath++;
            }
            if (other.Helth <= 0)
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

