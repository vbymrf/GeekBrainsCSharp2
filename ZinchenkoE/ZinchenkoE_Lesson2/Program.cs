﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZinchenkoE_Lesson2.Job;
namespace ZinchenkoE_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
1. Построить три класса (базовый и 2 потомка), описывающих работников с почасовой                      
оплатой  (один  из  потомков)  и  фиксированной оплатой (второй потомок): 
a. Описать в базовом классе абстрактный метод для расчета среднемесячной                  
заработной платы. Для «повременщиков» формула для расчета такова:
«среднемесячная заработная плата = 20.8 * 8 * почасовая ставка»; для работников с                          
фиксированной оплатой: «среднемесячная заработная плата = фиксированная              
месячная оплата»; 
b. Создать на базе абстрактного класса массив сотрудников и заполнить его; 
c. * Реализовать интерфейсы для возможности сортировки массива, используя                
Array.Sort()​; 
d. * Создать класс, содержащий массив сотрудников, и реализовать возможность вывода                    
данных с использованием ​foreach​. 
 * */
            Worker[] pepl=new Worker[10];
            string surname="Male",  name="Name", profession="Prof";
            double rate=50000;
            for (int i = 0; i < pepl.Length; i++)
            {
                if (i % 2 == 0) pepl[i] = new Employment(surname + i, name + i, profession + i, Math.Floor(rate * i / (i + 1)));
                else pepl[i] = new Freelance(surname + i, name + i, profession + i, Math.Floor( rate * i / (166*(i + 1))));
            }
            foreach (Worker w in pepl)
            {
                Console.WriteLine(w.ToString());
            }

            Array.Sort(pepl);

            Console.WriteLine();

            foreach (Worker w in pepl)
            {
                Console.WriteLine(w.ToString());
            }
            

            Console.ReadKey();
        }
    }
}
