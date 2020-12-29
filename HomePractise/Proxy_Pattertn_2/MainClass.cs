namespace Proxy_Pattertn_2
{
    public class MainClass
    {
        public static void Main(string [] args)
        {
            ExpensiveObject ex = new ProxyforRealClass();
            ex.process();
            
        }
    }
}
