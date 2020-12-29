using System.Collections.Generic;

namespace Proxy_Pattern
{
    public class ProxyInternet : Internet
    {
        private Internet internet = new RealInternet();

        public void connectTO(string serverhost)
        {
            internet.connectTO(serverhost);
            
        }
    }
}
