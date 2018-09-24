using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 80, 25 );
            //Убирает курсоры мегающие от змейки
            Console.CursorVisible = false;

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

            // бесконечный цыкл проверки какую кнопку нажали на клавиатуре в консоле
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo button = Console.ReadKey();
                    snake.Handbutton(button.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
 
        }
    }
}