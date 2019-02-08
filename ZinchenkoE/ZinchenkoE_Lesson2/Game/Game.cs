using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace ZinchenkoE_Lesson2
{
    
    class Game
    {
// Буфер
      public static BufferedGraphicsContext _context;
      public static BufferedGraphics Buffer;
/// <summary>
/// Массив созданных обьектов 
/// </summary>
      public static BaseObject[] _objs;
        public static Bullet _bullet;
        public static Asteroid[] _asteroids;
 
//размеры окна(буфера?)
      public static int Width { get; set; }
      public static int Height { get; set; }

      static Game()
      {

      }
        /// <summary>
        /// Вывод графики
        /// </summary>
        /// <param name="window">Наше окно</param>
      public static void Init(Form window) //Инициализация буфера для вывода графики (что бы убрать мерцание)
      {
         
          Graphics g; // Графическое устройство для вывода графики 
          _context = BufferedGraphicsManager.Current; // Создаем объект (поверхность рисования) 
          g = window.CreateGraphics();// связываем его с формой 
          // Запоминаем размеры формы 
          Width = window.ClientSize.Width;
          Height = window.ClientSize.Height;
          // Связываем буфер в памяти с графическим объектом, чтобы рисовать в буфере 
          Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Height));

          Load();
          Timer timer = new Timer { Interval = 100 };
          timer.Start();
          timer.Tick += Timer_Tick;
      }
        /// <summary>
        /// Выводим графику обьектов
        /// </summary>
      public static  void Draw()
      {

          // Формируем графический кадр в буфере
          Buffer.Graphics.Clear(Color.Black);
          Buffer.Graphics.DrawRectangle(Pens.White, new Rectangle(100, 100, 200,200));
          Buffer.Graphics.FillEllipse(Brushes.Wheat, new Rectangle(100, 100, 200,200));
          
          Buffer.Graphics.Clear(Color.Black);// Очищаем поверхность и делаем фон черным
          
          foreach (BaseObject obj in _objs) obj.Draw(); // Выводим обьекты на экран

          //Выводим его на экран
          Buffer.Render();   
      }
        
        /// <summary>
        /// Обновляем координаты обьектов
        /// </summary>
      public  static void Update()
      {
          foreach (BaseObject obj in _objs) obj.Update();
      }



        /// <summary>
        /// Создание обьектов 
        /// </summary>
      public static void Load()         
      {
          int j = 0;
          _objs = new BaseObject[60];
          for (int i = 0; i < _objs.Length / 3; i++)
          {
              j = i;
             // _objs[i] = new BaseObject(new Point(600, j * 20), new Point(-i, -i), new Size(10, 10));
          }
              for (int i = _objs.Length / 3; i < _objs.Length * 2 / 3; i++)
              {
                  j = i - _objs.Length / 3;
                  _objs[i] = new Star(new Point(600, j * 30), new Point(-i, 0), new Size(5, 5));
              }
              for (int i = _objs.Length * 2 / 3; i < _objs.Length-1; i++)
              {
                  j = i - _objs.Length * 2 / 3;
                  _objs[i] = new Line(new Point(600, j * 30), new Point(-i-j, 0), new Size(5, 5));
              }
              _objs[_objs.Length-1] = new MyImage();

              _objs = new BaseObject[30];
              _bullet = new Bullet(new Point(0, 200), new Point(5, 0), new Size(4, 1));
              _asteroids = new Asteroid[3];
              var rnd = new Random();
              for (var i = 0; i < _objs.Length; i++)
              {
                  int r = rnd.Next(5, 50);
                  _objs[i] = new Star(new Point(1000, rnd.Next(0, Game.Height)), new
          Point(-r, r), new Size(3, 3));
              }
              for (var i = 0; i < _asteroids.Length; i++)
              {
                  int r = rnd.Next(5, 50);
                  _asteroids[i] = new Asteroid(new Point(1000, rnd.Next(0, Game.Height)),
          new Point(-r / 5, r), new Size(r, r));
              } 

      }

        /// <summary>
        /// Обработчик таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      private static void Timer_Tick(object sender, EventArgs e)
      {
          
          Draw();
          Update();
      } 
    }
}
