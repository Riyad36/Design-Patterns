using System.Collections.Generic;

namespace CompositePattern
{
    public class CompanyDirectory : Component
    {

        private List<Component> ComponentList = new ArrayList<Component>();

        public void showEmployeeDetails()
        {
            foreach (Component comp in ComponentList)
            {
                comp.showEmployeeDetails();
            }
        }

        public void addEmployee(Component comp)
        {
            ComponentList.Add(comp);
        }

        public void removeEmployee(Component comp)
        {
            ComponentList.Remove(comp);
        }
    }
}
