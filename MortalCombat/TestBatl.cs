using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MortalCombat
{
    class TestBatl
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                FirstHerro firstHerro = new FirstHerro("Люкенг", 100, 10, 15, 15);
                SecondHerro secondHerro = new SecondHerro("Китана", 100, 10, 15, 10);
                firstHerro.Ulta += FirstHerro_Ulta;
                secondHerro.Uklon += SecondHerro_Uklon;
                firstHerro.Dead += FirstHerro_Dead;
                secondHerro.Dead += SecondHerro_Dead;
                firstHerro.Victory += FirstHerro_Victory;
                secondHerro.Victory += SecondHerro_Victory;
                Console.WriteLine(firstHerro);
                Console.WriteLine(secondHerro);
                while (secondHerro.Helth > 0 && firstHerro.Helth > 0)
                {
                    firstHerro.Attack(secondHerro);
                    firstHerro.CheckVictoryORDeath(secondHerro);
                    Thread.Sleep(1);
                    //ответка
                    secondHerro.Attack(firstHerro);
                    firstHerro.CheckVictoryORDeath(firstHerro);
                    Console.WriteLine(firstHerro);
                    Console.WriteLine(secondHerro);
                }
            }

            Console.WriteLine($"{FirstHerro.countVictory}    {SecondHerro.countVictory}");
        }

        private static void SecondHerro_Victory(object sender, ResultBatle e)
        {
            Console.WriteLine(e.Message);
        }

        private static void FirstHerro_Victory(object sender, ResultBatle e)
        {
            Console.WriteLine(e.Message);
        }

        private static void SecondHerro_Dead(object sender, ResultBatle e)
        {
            Console.WriteLine(e.Message);
        }

        private static void FirstHerro_Dead(object sender, ResultBatle e)
        {
            Console.WriteLine(e.Message);
        }

        private static void SecondHerro_Uklon(object sender, AbilityEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private static void FirstHerro_Ulta(object sender, AbilityEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
