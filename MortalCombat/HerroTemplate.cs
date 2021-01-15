using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalCombat
{
    abstract class HerroTemplate
    {
        public virtual string Name { get; private set; }
        public virtual int Helth { get;  set; }
        public virtual int Damage { get; set; }

        public int MinDamage { get; }
        public virtual int MaxDamage { get; set; }

        public virtual event EventHandler<ResultBatle> Dead;
        public virtual event EventHandler<ResultBatle> Victory;
       // public virtual event EventHandler<UltaEventArgs> Ulta;

        public HerroTemplate(string name, int helth, int minDamage, int maxDamage)
        {
            Name = name;
            Helth = helth;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            GenerateAttack(minDamage, maxDamage);
        }

        protected HerroTemplate()
        {
        }

        public virtual void Attack(HerroTemplate otherHerro)
        {
            otherHerro.GetDamage(Damage);
        }

        public virtual void GetDamage(int damage)
        {
            Helth -= damage;
        }

        public virtual void GenerateAttack(int min, int max)
        {
            Random random = new Random();
            Damage = random.Next(min, max + 1);
        }
    }
}
