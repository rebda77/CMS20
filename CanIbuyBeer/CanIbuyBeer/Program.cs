// om ålder >17 and location == ”krogen” 

//om Ålder > 19 and location == ”Systemet”

//om leg == "j" JA

//om promillehalten <1.0 

using System;

namespace CanIBuyBeer
{
    class Program
    {

        static bool CanIBuyBeer(int age, string location, decimal promille, string legg)
        {
            bool canIBuyBeer = false;
            if (legg == "J" && age > 17)
            {
                if (location == "krogen" && age > 15)
                {
                    canIBuyBeer = true;
                }

                else if (location == "systemet" && age > 17)
                {
                    canIBuyBeer = true;
                }
                else
                {
                    canIBuyBeer = false;
                }

            }

            return CanIBuyBeer
    }

        static Main(string[] args)
        {






            Console.WriteLine("Hur gammal är du?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Location:");
            string location = Console.ReadLine();
            location = location.ToLower();

            Console.WriteLine("Har du legg med dig (J/N):");
            string legg = Console.ReadLine();
            Console.Write("Vilken promillehalt?");
            decimal promille = Convert.ToDecimal(ConsoleReadLine());


            //bool canIBuyBeer = false;
            //if (legg == "J" && age > 17)
            //{
            //    if (location == "krogen" && age > 17)
            //    {
            //        canIBuyBeer = true;
            //    }

            //    else if (location == "systemet" && age > 17)
            //    {
            //        canIBuyBeer = true;
            //    }
            //    else
            //    {
            //        canIBuyBeer = false;
            //    }

        }
            if(canIBuyBeer == true)
                Console.WriteLine("Du får köpa öl!");
            else
                Console.WriteLine("Du får inte köpa öl!");



            //if (age > 17 && location == "krogen" && legg == "J" && promille < 1.0m)
            //    Console.WriteLine("Japp du får köpa öl");
            //else if (age > 19 && location == "Systemet" && legg == "J" && promille < 1.0m)
            //    Console.WriteLine("Japp du får köpa öl");
            //else
            //    Console.WriteLine("Du får inte köpa öl");
        }
}
}
