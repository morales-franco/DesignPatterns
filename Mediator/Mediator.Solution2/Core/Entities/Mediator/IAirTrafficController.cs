namespace Mediator.Solution2.Core.Entities.Mediator
{
    public interface IAirTrafficController
    {
        bool ExistsAnotherAircraftWithPriorityToLand(Aircraft aircraft);
        void ReceiveAircraftLocation(Aircraft aircraft);
        void RegisterAircraftUnderGuidance(Aircraft aircraft);
        void NotifyAircraftLanding(Aircraft aircraft);
        void NotifyAircraftLandingFinished(Aircraft aircraft);
    }
}
