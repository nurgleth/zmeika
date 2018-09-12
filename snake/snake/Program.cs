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

            Point p3 = new Point(8, 10, '&');
            p3.Draw();

            Point p4 = new Point(12, 12, '$');
            p4.Draw();

            HorizontalLine lineX = new HorizontalLine(4, 8, 14, '+');
            lineX.Drow();

            Vertical lineY = new Vertical(12, 20, 6, '+');
            lineY.Drow();

            Console.ReadLine();
        }

    }

}