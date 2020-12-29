using System;

namespace NullObject_Pattern
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(String name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

        public override bool isNull()
        {
            return false;
        }
    }
}
