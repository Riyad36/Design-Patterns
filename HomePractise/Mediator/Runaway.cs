using System;

namespace Mediator
{
    public class Runaway : Command
    {
        private IATCMediator atcMediator;

        public Runway(IATCMediator atcMediator)
        {
            this.atcMediator = atcMediator;
            atcMediator.setLandingStatus(true);
        }

        
    public void land()
        {
            Console.WriteLine("Landing permission granted.");
            atcMediator.setLandingStatus(true);
        }
    }
}
