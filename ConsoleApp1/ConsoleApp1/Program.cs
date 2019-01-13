using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize( 80, 25 );
            //отрисовка рамочки
            HoriczontalLine upLine = new HoriczontalLine(0, 78, 0, '+');
            HoriczontalLine downLine = new HoriczontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
            //отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadLine();
        }
    }
}
