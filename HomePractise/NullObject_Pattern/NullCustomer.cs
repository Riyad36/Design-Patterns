namespace NullObject_Pattern
{
    public class NullCustomer : AbstractCustomer
    {

        public override string getName()
        {
            return "Not Available";
        }

        public override bool isNull()
        {
            return true;
        }
    }
}
