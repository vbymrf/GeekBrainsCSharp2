using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZinchenkoE_Lesson2
{
    class Star : ​BaseObject 
    {
         ​public​ ​Star​(Point pos, Point dir, Size size):​base​(pos,dir,size) 
   { 
   }
        /// <summary>
        /// Создание крестика (звезда)
        /// </summary>
          public override void Draw()
          {
              Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X, Pos.Y, Pos.X + Size.Width, Pos.Y + Size.Height);
              Game.Buffer.Graphics.DrawLine(Pens.White, Pos.X + Size.Width, Pos.Y, Pos.X, Pos.Y + Size.Height);
          }
          public override void Update()
          {
              if( Pos.X > Pos.X - Dir.X) Pos.X = Pos.X - Dir.X;// Ось у меня Х направлена по другому (почему не знаю), поэтому пришлось поправить
              else Pos.X = Pos.X + Dir.X;
              if (Pos.X < 0) Pos.X = Game.Width + Size.Width;
          } 

    }
}
