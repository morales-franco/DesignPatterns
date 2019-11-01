using Mediator.Solution1.Core.Entities;
using System;

namespace Mediator.Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iron Airport without Air Traffic Controller - without Mediator ;)");

            //Creating flights
            var flightA = new AirbusA320Neo("FLIGHT A", 100);
            var flightB = new Atr72("FLIGHT B", 50);
            var flightC = new Boeing777300("FLIGHT C", 25);

            //All aircraft need to know to each other
            flightA.Acknoledges(flightB);
            flightA.Acknoledges(flightC);

            flightB.Acknoledges(flightA);
            flightB.Acknoledges(flightC);

            flightC.Acknoledges(flightA);
            flightC.Acknoledges(flightB);

            //Flight A wants to land! It needs to do previous checks before landing.
            if (!flightA.ExistAnotherAircraftWithPriorityToLand())
                flightA.Land();

            //If flight B wants to land, it needs to do the same! It needs to consult its internal collection too
            if (!flightB.ExistAnotherAircraftWithPriorityToLand())
                flightB.Land();

            //If flight C wants to land, it needs to do the same! It needs to consult its internal collection too
            if (!flightC.ExistAnotherAircraftWithPriorityToLand())
                flightC.Land();

            //Can you imagine if we have a lot of flights? 
        }
    }
}
