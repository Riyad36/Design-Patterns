using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NullObject_Pattern
{
    public abstract class AbstractCustomer
    {
        protected string name;

        public abstract Boolean isNull();
        public abstract string getName();

    }
}
