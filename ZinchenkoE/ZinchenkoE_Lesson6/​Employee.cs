using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinchenkoE_Lesson6
{
    class Employee
    {
        string Name;
        string SurName;
        string Professian;
        public  Department depEmployee;

        public Employee()
        {
            Random ran = new Random();
            this.Name = "Name" + ran.Next();
            this.SurName = "SurName" + ran.Next();
            this.Professian = "Professian" + ran.Next();
            this.depEmployee=null;
        }

        public Employee ChangeEmployee(Employee e,string Name, string SurName, string Professian)
        {
            if (e != null)
            {
                if (Name != null && Name != "0") this.Name = Name;
                if (SurName != null && SurName != "0") this.SurName = SurName;
                if (Professian != null && Professian != "0") this.Professian = Professian;
            }
            return e;
        }
        public void ChangeDeportament(Employee e, Department d)
        {
            d.DeletEmployee(e);
            d.AddEmployee(e);
        }
    }
}
