using System;

namespace CompositePattern
{
    public class Manager : Component
    {

        private string name;
        private long empId;
        private string position;

        public Manager(long empId, string name, string position)
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
