using System;

namespace Mediator
{
    public internal interface IATCMediator
    {
        public void registerRunaway(Runway runway);
        public void registerFlight(Flight flight);
        public Boolean isLandingOk();
        public void setLandingStatus(Boolean status);
    }
}
