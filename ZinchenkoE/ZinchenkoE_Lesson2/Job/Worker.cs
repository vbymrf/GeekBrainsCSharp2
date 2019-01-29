using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZinchenkoE_Lesson2.Job
{
    /// <summary>
    /// Клас Работник
    /// </summary>
    abstract class Worker : IComparable
    {
       protected string surname;
       protected string name;
       protected string profession;
       public double rate;
        public Worker(string surname, string name, string profession, double rate)
        {
            this.surname = surname;
            this.name = name;
            this.profession = profession;
            this.rate = rate;
        }

        public abstract double Payment();
            
      
        public virtual string ToString()
        {
            return "Фамилия: " + this.surname + "; Имя:" + this.name + "; Профессия" + this.profession + "; Заработная плата:" + this.rate;
        }
        /// <summary>
        /// Определяем сортировку класса по заработанной плате
        /// </summary>
        /// <param name="obj"> передача самого себя</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) throw new Exception("Невозможно сравнить два объекта");

            if (obj is Worker)
            {
                return this.rate.CompareTo(((Worker)obj).rate);

            }
            else throw new InvalidOperationException();
        }

        

    }
}
