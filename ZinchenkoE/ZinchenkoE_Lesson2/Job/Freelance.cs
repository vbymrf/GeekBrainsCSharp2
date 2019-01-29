using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinchenkoE_Lesson2.Job
{
    class Freelance : Worker
    {
        /// <summary>
        /// Оплата за один час
        /// </summary>
        double hourRate;
        /// <summary>
        /// Часовая нагрузка в месяц
        /// </summary>
        double Hour{
            get { return 20.8 * 8; }
            set { }
        }
        public Freelance(string surname, string name, string profession, double hourRate)
            : base(surname, name, profession,0)
        {
            this.hourRate=hourRate;
            this.rate = base.rate = Payment();
    }

        public override double Payment()
        {
            return rate =  Hour * hourRate;            
        }
        public override string ToString()
        {
            return "Фамилия: " + this.surname + "; Имя:" + name + "; Профессия" + this.profession + "; Оплата в час:" + rate + "; Заработная плата:" + this.Payment();
        }

    }
}
