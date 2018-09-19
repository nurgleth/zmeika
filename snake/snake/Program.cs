using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 80, 25 );
  
            // Рамка игры
            HorizontalLine UplineX = new HorizontalLine(0, 78, 0, '+');
            UplineX.Drow();
            HorizontalLine DownLineX = new HorizontalLine(0, 78, 24, '+');
            DownLineX.Drow();
            Vertical LeftlineY = new Vertical(0, 24, 0, '+');
            LeftlineY.Drow();
            Vertical RightLineY = new Vertical(0, 24, 78, '+');
            RightLineY.Drow();

            // Наша змейка на старте
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }

    }

}