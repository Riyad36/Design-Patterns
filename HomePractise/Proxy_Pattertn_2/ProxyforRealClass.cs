namespace Proxy_Pattertn_2
{
    public class ProxyforRealClass : ExpensiveObject
    {
        ExpensiveObject expensiveObject = new RealClass();
        public void process()
        {
            expensiveObject.process();
        }

        

    }
}
