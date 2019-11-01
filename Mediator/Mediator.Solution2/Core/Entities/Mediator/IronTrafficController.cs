using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator.Solution2.Core.Entities.Mediator
{
    public class IronTrafficController: IAirTrafficController
    {
        private readonly IList<Aircraft> _aircrafts;

        public IronTrafficController()
        {
            _aircrafts = new List<Aircraft>();
        }

        public void RegisterAircraftUnderGuidance(Aircraft aircraft)
        {
            Logging($">Traffic Controller: Hello { aircraft.FlightName}! I'm taking notes about you! Tell me when you want to land or change your location!");
            _aircrafts.Add(aircraft); //Registering new colleague!
        }

        public void NotifyAircraftLanding(Aircraft aircraft)
        {
            Logging($">Traffic Controller: Received { aircraft.FlightName}! I'm gonna notify that you are landing to the other pilots!");
            foreach (var receivingAircraft in _aircrafts.Where(a => a != aircraft))
            {
                receivingAircraft.WarningAircraftLanding(aircraft.FlightName); //Sending a message to colleagues!
            }
        }

        public void NotifyAircraftLandingFinished(Aircraft aircraft)
        {
            Logging($">Traffic Controller: Received { aircraft.FlightName}, Excellent! I'm gonna notify that you have already landed the other pilots!");
            foreach (var receivingAircraft in _aircrafts.Where(a => a != aircraft))
            {
                receivingAircraft.AttentionLandingTrackAvailable();
            }
        }

        public bool ExistsAnotherAircraftWithPriorityToLand(Aircraft sender)
        {
            bool existsAircraftWithMorePriorityToLand = false;

            Logging($">Traffic Controller: I received your requirement { sender.FlightName}, I'm checking the priorities to land");

            foreach (var aircraft in _aircrafts.Where(a => a != sender))
            {
                if (aircraft.Altitude <= sender.Altitude)
                {
                    Logging($">Traffic Controller: You must wait! The  { aircraft.FlightName} flight has the priority to land right now!");
                    existsAircraftWithMorePriorityToLand = true;
                    break;
                }
            }

            return existsAircraftWithMorePriorityToLand;
        }


        public void ReceiveAircraftLocation(Aircraft aircraft)
        {
            Logging($">Traffic Controller: Received { aircraft.FlightName}! I'm gonna notify your new location to the other pilots!");
            foreach (var receivingAircraft in _aircrafts.Where(a => a != aircraft))
            {
                receivingAircraft.VerifySafeDistance(aircraft.Altitude);
            }
        }

        
        internal void Logging(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
