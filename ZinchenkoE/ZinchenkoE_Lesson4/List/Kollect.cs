using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Дана коллекция ​List<T>​. Требуется подсчитать, сколько раз каждый элемент встречается в
данной коллекции: 

 
*/


namespace ZinchenkoE_Lesson4.List
{
    class Kollect
    {
//a.для целых чисел; 
 public static int Count(List<int> lis)
        {
            int n = 0;
            for (int i = 0; i < lis.Count; i++)
            {
                for (int j = 0; j < lis.Count; j++)
                {
                    if (i != j) if (lis[i].Equals(lis[j])) n++;
                }
            }
            return n;
        }
//b. * для обобщенной коллекции;
        public static int Count<T>(List<T> lis)
        {
            int n = 0;
           for (int i = 0; i < lis.Count; i++)
            {
                for (int j = 0; j < lis.Count; j++)
                {
                    if (i != j) if(lis[i].Equals(lis[j])) n++;
                }
            }
            return n;
        }
        public static int CountLinq<T>(List<T> lis)
        {
            int k = 0;
          
// ​var​ posNums ​=​ ​from​ n       
//  ​in​ lis 
// ​where​ 
//from m in lis
//where n==m
//​select n​; ​      
            return k;
        }
      
  //     c. ** используя Linq.


    }
    }
}
