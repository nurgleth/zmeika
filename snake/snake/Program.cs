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


            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(8, 10, '&');
            p3.Draw();

            Point p4 = new Point(12, 12, '$');
            p4.Draw();

            HorizontalLine UplineX = new HorizontalLine(0, 78, 0, '+');
            UplineX.Drow();
            HorizontalLine DownLineX = new HorizontalLine(0, 78, 24, '+');
            DownLineX.Drow();
            Vertical LeftlineY = new Vertical(0, 24, 0, '+');
            LeftlineY.Drow();
            Vertical RightLineY = new Vertical(0, 24, 78, '+');
            RightLineY.Drow();

            Console.ReadLine();
        }

    }

}