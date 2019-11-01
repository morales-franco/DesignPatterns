using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Solution1.Core.Entities
{
    public abstract class Aircraft
    {
        private readonly IList<Aircraft> _acknoledgeAircrafts;

        public int Altitude { get; private set; }
        public string FlightName { get; private set; }
        public Aircraft()
        {
            _acknoledgeAircrafts = new List<Aircraft>();
        }

        public Aircraft(string flightName, int altitude)
            :this()
        {
            Altitude = altitude;
            FlightName = flightName;
        }

        public virtual bool ExistAnotherAircraftWithPriorityToLand()
        {
            bool existsAircraftWithMorePriorityToLand = false;

            foreach (var aircraft in _acknoledgeAircrafts)
            {
                if (aircraft.Altitude <= this.Altitude)
                {
                    existsAircraftWithMorePriorityToLand = true;
                    break;
                }
            }

            return existsAircraftWithMorePriorityToLand;
        }

        public void Acknoledges(Aircraft aircraft)
        {
            _acknoledgeAircrafts.Add(aircraft);
        }

        public virtual void Land()
        {
            Console.WriteLine($"{ FlightName } is landing");
        }
    }
}
