using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZinchenkoE_Lesson_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form window =new Form();
            window.Width = 800;
            window.Height = 600;
            Game.Init(window); 
            window.Show();
            Game.Draw(); 
            Application.Run(window);

            
        }
    }
}
