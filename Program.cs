using System;
using System.Collections.Generic;

namespace csharp_Interface_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var ant = new Ant();
            var bettafish = new BettaFish();
            var copperhead = new Copperhead();
            var earthworm = new Earthworm();
            var finch = new Finch();
            var gerbil = new Gerbil();
            var mouse = new Mouse();
            var painterDog = new PaintedDog();
            var parakeet = new Parakeet();
            var seaTurtle = new SeaTurtle();
            var terrapin = new Terrapin();
            var timberRattler = new TimberRattlesnake();


            List<IWalking> LandAnimals = new List<IWalking>();
            LandAnimals.Add(ant);
            LandAnimals.Add(copperhead);
            LandAnimals.Add(finch);
            LandAnimals.Add(gerbil);
            LandAnimals.Add(mouse);
            LandAnimals.Add(painterDog);
            LandAnimals.Add(parakeet);
            LandAnimals.Add(seaTurtle);
            LandAnimals.Add(terrapin);
            LandAnimals.Add(timberRattler);

            System.Console.WriteLine("Land Animals");
            System.Console.WriteLine("----------------------");
            foreach (IWalking animal in LandAnimals)
            {
                System.Console.WriteLine($"{animal}");
            }
            System.Console.WriteLine("----------------------");

            List<ISwimming> Swimmers = new List<ISwimming>();
            Swimmers.Add(bettafish);
            Swimmers.Add(copperhead);
            Swimmers.Add(seaTurtle);
            Swimmers.Add(terrapin);

            System.Console.WriteLine("Swimmers");
            System.Console.WriteLine("----------------------");
            foreach (ISwimming swimmers in Swimmers)
            {
                System.Console.WriteLine($"{swimmers}");
            }
            System.Console.WriteLine("----------------------");

            List<IDigging> Diggers = new List<IDigging>();
            Diggers.Add(ant);
            Diggers.Add(earthworm);
            Diggers.Add(gerbil);
            Diggers.Add(mouse);

            System.Console.WriteLine("Diggers");
            System.Console.WriteLine("----------------------");
            foreach (IDigging diggers in Diggers)
            {
                System.Console.WriteLine($"{diggers}");
            }
            System.Console.WriteLine("----------------------");

            List<IFlying> WingedBeasts = new List<IFlying>();
            WingedBeasts.Add(finch);
            WingedBeasts.Add(parakeet);

            System.Console.WriteLine("SKEWER THE WINGED BEAST!!!!");
            System.Console.WriteLine("----------------------");
            foreach (IFlying wingedBeasts in WingedBeasts)
            {
                System.Console.WriteLine($"{wingedBeasts}");
            }
            System.Console.WriteLine("----------------------");
        }
    }
}
