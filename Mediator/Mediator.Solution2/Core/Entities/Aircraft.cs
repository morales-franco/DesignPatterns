using Mediator.Solution2.Core.Entities.Mediator;
using System;

namespace Mediator.Solution2.Core.Entities
{
    public abstract class Aircraft
    {
        private IAirTrafficController _airTrafficController;
        public int Altitude { get; private set;  }
        public string FlightName { get; private set; }

        public Aircraft(IAirTrafficController airTrafficController,string flightName, int altitude)
        {
            FlightName = flightName;
            Altitude = altitude;
            _airTrafficController = airTrafficController;
            _airTrafficController.RegisterAircraftUnderGuidance(this);
        }

        public virtual void Land()
        {
            Logging($">{ FlightName }: I wanna land! is any aircraft landing?");
            if (_airTrafficController.ExistsAnotherAircraftWithPriorityToLand(this))
            {
                Logging($">{ FlightName }: Received! I'm gonna wait!");
                return;
            }

            Logging($">{ FlightName }: Perfect! Let's go! I begin to land!");
            _airTrafficController.NotifyAircraftLanding(this);

            Logging($">{ FlightName }: I'm landing!");
            Logging($">{ FlightName }: I've just finished to land! ");
            _airTrafficController.NotifyAircraftLandingFinished(this);
        }

        internal void WarningAircraftLanding(string flightName)
        {
            Logging($">{ FlightName }: Received! Please, Let me know when the { flightName } flight is landed");
        }

        internal void AttentionLandingTrackAvailable()
        {
            Logging($">{ FlightName }: Received! I'm near airport! I'll try to land in 20 minutes!");
        }

        internal void VerifySafeDistance(int altitudeOfAnotherAircraft)
        {
            Logging($">{ FlightName }: Received! I'm checking my safe distance");

            if(Math.Abs(altitudeOfAnotherAircraft - Altitude) < 100)
            {
                Logging($">{ FlightName }: I'm close to the another aircraft! I'm gonna drive carefully!");
            }

        }

        public abstract void SetDefaultColor();

        internal void Logging(string message)
        {
            SetDefaultColor();
            Console.WriteLine(message);
            Console.ResetColor();
        }

        internal void ChangeLocation(int newAltitude)
        {
            Logging($">{ FlightName }: I'm moving on - {newAltitude} meters!");
            Altitude += newAltitude;
            _airTrafficController.ReceiveAircraftLocation(this);
        }
    }
}
