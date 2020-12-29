using System;

namespace Proxy_Pattern
{
    public class RealInternet : Internet
    {
        public void connectTO(string serverhost)
        {
            Console.WriteLine("Connecting to "+serverhost);
        }
    }
}

