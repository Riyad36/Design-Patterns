using System;

namespace CompositePattern
{
    public class Developer : Component
    {
        private string name;
        private long empId;
        private string position;

        public Developer(long empId, string name, string position)
        {
            this.empId = empId;
            this.name = name;
            this.position = position;
        }


        public void showEmployeeDetails()
        {
            Console.WriteLine(empId + " " + name);
        }
    }
}
