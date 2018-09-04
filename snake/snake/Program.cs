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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            

            Point p2 = new Point(4, 5, '#');
            p2.Draw();
                       
            Move(p1, 15, 10);
            p1.Draw();

            Point p3 = new Point(8, 8, '=');
            //Obratka(p3);
            p3.Draw();

            Console.ReadKey();
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
        /*public static void Obratka(Point p)
        {
            p = new Point(1,1,'1');
        }*/


    }

} 