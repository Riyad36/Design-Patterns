using System;

namespace Mediator
{
    public class Flight : Command
    {
        private IATCMediator atcMediator;

        public Flight(IATCMediator atcMediator)
        {
            this.atcMediator = atcMediator;
        }

        public void land()
        {
            if (atcMediator.isLandingOk())
            {
                Console.WriteLine("Successfully Landed.");
                atcMediator.setLandingStatus(true);
            }
            else
                Console.WriteLine("Waiting for landing.");
        }

        public void getReady()
        {
            Console.WriteLine("Ready for landing.");
        }
    }
}
