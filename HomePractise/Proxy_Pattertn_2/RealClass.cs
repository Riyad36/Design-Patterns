using System;

namespace Proxy_Pattertn_2
{
    public class RealClass : ExpensiveObject
    {
        public void process()
        {
            Console.WriteLine("Processing Complete");
        }

        private void HeavyInitialConfig()
        {
            Console.WriteLine("Loading Initial Configuration...");
        }
    }
}
