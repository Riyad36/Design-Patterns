using System;

namespace Mediator
{
    public class ATCMediator : IATCMediator
    {

        private Flight flight;
        private Runway runway;
        public boolean land;

        public bool isLandingOk()
        {
            return land;
        }

        public void registerFlight(Flight flight)
        {
            this.flight = flight;
        }

        public void registerRunaway(Runway runway)
        {
            this.runway = runway;
        }

        public void setLandingStatus(bool status)
        {
            land = status;
        }
    }
}
