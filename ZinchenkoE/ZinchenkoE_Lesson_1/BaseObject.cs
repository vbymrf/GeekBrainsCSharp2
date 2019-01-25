using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using​ System.Drawing; 
namespace ZinchenkoE_Lesson_1
{
    /// <summary>
    /// Обьекты в игре
    /// </summary>
    class BaseObject
    { 
        protected​ Point Pos; 
        /// <summary>
        /// Размер движения обьекта при соприкосновении
        /// </summary>
        ​protected​ Point Dir; 
        ​protected​ Size Size; 
        /// <summary>
        /// Создание обьекта 
        /// </summary>
        /// <param name="pos">Позиция (Х У) </param>
        /// <param name="dir">Смещение</param>
        /// <param name="size">Размер</param>
        public​ ​BaseObject​(Point pos, Point dir, Size size) 
        { 
            Pos = pos; 
            Dir = dir; 
            Size = size; 
        } 
        /// <summary>
        ///  Создание круга
        /// </summary>
​       public​ virtual ​void​ ​Draw​() 
        { 
            Game.Buffer.Graphics.DrawEllipse(Pens.White, Pos.X, Pos.Y,Size.Width, Size.Height); 
        }
        
        /// <summary>
        /// Смещение обьекта при соприкосновении
        /// </summary>
        public virtual void Update()
        {
            Pos.X = Pos.X + Dir.X;
            Pos.Y = Pos.Y + Dir.Y;
            if (Pos.X < 0) Dir.X = -Dir.X;
            if (Pos.X > Game.Width) Dir.X = -Dir.X;
            if (Pos.Y < 0) Dir.Y = -Dir.Y;
            if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
        } 
    }
}



 
