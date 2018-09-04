using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
            
        }


        public void Draw() 
        {
            int i;
            Random iRand = new Random();
            i = iRand.Next(16);
            Console.ForegroundColor = (ConsoleColor)i;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        /*public void Draw() //Если
        {
            if (Console.ForegroundColor != (ConsoleColor)15)
                Console.ForegroundColor = (ConsoleColor)15;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }*/
    }

}
