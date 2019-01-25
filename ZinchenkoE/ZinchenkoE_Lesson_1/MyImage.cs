using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZinchenkoE_Lesson_1
{
    class MyImage : BaseObject
    {
        public MyImage()
            : base(new Point(1, 1), new Point(1, 1), new Size(1, 1)) 
        {
        }
        public override void Draw()
        {
            Image newImage = System.Drawing.Image.FromFile(@"m.jpg");
             Game.Buffer.Graphics.DrawImage(newImage, 250, 250);
           
        }
        public override void Update()
        {
            
        } 
    }
}
