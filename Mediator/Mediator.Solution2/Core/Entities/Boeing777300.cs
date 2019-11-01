using Mediator.Solution2.Core.Entities.Mediator;
using System;

namespace Mediator.Solution2.Core.Entities
{
    public class Boeing777300: Aircraft
    {
        public Boeing777300(IAirTrafficController airTrafficController, string flightName, int altitude)
            : base(airTrafficController, flightName, altitude)
        {
        }

        public override void SetDefaultColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
