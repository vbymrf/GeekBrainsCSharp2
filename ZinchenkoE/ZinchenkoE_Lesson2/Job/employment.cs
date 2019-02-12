using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinchenkoE_Lesson2.Job
{
    class Employment : Worker
    {
          
        public Employment(string surname, string name, string profession, double rate) : base(surname, name, profession, rate) { }
          

        public override double Payment()
        {
            return rate ;           
        }

    }
}
