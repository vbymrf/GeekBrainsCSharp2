using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZinchenkoE_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] lis = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
​var​ posNums ​=​ ​from​ n ​in​ lis 
                      ​where​ n ​>​ ​0
                      ​where​ n ​<​ ​10
                      ​select​ n;


            Console.WriteLine(typeof(int));
            Console.ReadKey();
        }
    }
}
