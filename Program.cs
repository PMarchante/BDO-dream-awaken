using System;
using System.Collections.Generic;

namespace tests
{
    class Program
    {


        public double DreamHorse(int attempts)
        {
            double baseChance = 0.98;
            double oddsOfgettingHorse = baseChance;
            for (int x = 0; x < attempts; x++)
            {
                if (x != 0)
                {
                    baseChance = (baseChance - (.002));
                }
                oddsOfgettingHorse *= baseChance;
            }

            return (1 - oddsOfgettingHorse) * 100;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            string t = "nooooo";

            int attempt = 30;
            double chance = p.DreamHorse(attempt);
            Console.WriteLine("chance of getting horse with " + attempt + "attempts is " + chance);

        }

    }
}
