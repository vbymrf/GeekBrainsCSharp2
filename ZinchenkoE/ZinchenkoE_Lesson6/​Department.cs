using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinchenkoE_Lesson6
{
    class Department
    {
        string Name;
        public static int Number = 0;
        List<Employee> Data;

        public static List<Department> DepartmentList=new List<Department>();

        public Department()
        {
            Number++;
            this.Name = "Departament" + Number;            
            //this.Data.Add(null);
        }
        public Department(int kol)
        {
            Number++;
            this.Name = "Departament" + Number;
            for (int i = 0; i < kol; i++)
            {
            Employee ee = new Employee();
            this.Data.Add(ee);
            ee.depEmployee = this;
            } 
        }
        public Department ChangeDepartment (string Name)
        {
            this.Name = Name;
            return this;
        }
        public void AddEmployee(Employee e)
        {
            foreach(Employee em in this.Data)
            {
               if( e.Equals(e)) return;
            }
            Data.Add(e);
            e.depEmployee = this;
        }
        public void DeletEmployee(Employee e)
        {
            Data.Remove(e);
            e.depEmployee = null;
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
