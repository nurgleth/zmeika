﻿using System;
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
        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        // Метод движения точки по направлению direction
        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        //проверка равенства координат головы мейки и еды
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
             
        // Метод удаления хвостовой точки для движения
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        // Метод вывода на экран символов
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        // Фишка, чтобы было удобно смотреть за переменной Поинт
        /*public override string ToString()
        {
            return x = ", " + y + ", " + sym;
        }*/

    }
}
