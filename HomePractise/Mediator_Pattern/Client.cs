using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    class Client
    {
        public static void Main (string[] args)
        {
            Internet internet = new ProxyInternet();

            internet.connectTO("geeksforgeeks.org");
        }
    }
}
