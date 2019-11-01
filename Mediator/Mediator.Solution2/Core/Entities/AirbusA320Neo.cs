using Mediator.Solution2.Core.Entities.Mediator;
using System;

namespace Mediator.Solution2.Core.Entities
{
    class AirbusA320Neo : Aircraft
    {
        public AirbusA320Neo(IAirTrafficController airTrafficController, string flightName, int altitude)
            : base(airTrafficController, flightName, altitude)
        {
        }

        public override void SetDefaultColor()
        {
            //For logging
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
