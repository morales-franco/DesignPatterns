using Mediator.Solution2.Core.Entities.Mediator;
using System;

namespace Mediator.Solution2.Core.Entities
{
    public class Atr72: Aircraft
    {
        public Atr72(IAirTrafficController airTrafficController, string flightName, int altitude)
            : base(airTrafficController, flightName, altitude)
        {
        }

        public override void SetDefaultColor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
