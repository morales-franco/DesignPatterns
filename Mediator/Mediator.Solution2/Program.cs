using Mediator.Solution2.Core.Entities;
using Mediator.Solution2.Core.Entities.Mediator;
using System;

namespace Mediator.Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iron Airport with Air Traffic Controller - Power of the Mediator Pattern;)");

            //Mediator ! All interaction between aircraft must be doing through the traffic controller!
            IAirTrafficController trafficController = new IronTrafficController();

            //Declare Colleagues and associate them with the Air Traffic Controller (Mediator)
            AirbusA320Neo flightA = new AirbusA320Neo(trafficController, "Flight A", 2000);
            Atr72 flightB = new Atr72(trafficController, "Flight B", 1500);
            Boeing747 flightC = new Boeing747(trafficController, "Flight C", 1460);
            Boeing777300 flightD = new Boeing777300(trafficController, "Flight D", 1300);

            //flightA wants to land!
            flightA.Land();
            Console.WriteLine();

            //flightB wants to land!
            flightB.Land();
            Console.WriteLine();

            //flight C is moving on 100mts (changing altituded!) 
            flightC.ChangeLocation(100);
            Console.WriteLine();

            //flightD wants to land!
            flightD.Land();
            Console.WriteLine();
        }
    }
}
