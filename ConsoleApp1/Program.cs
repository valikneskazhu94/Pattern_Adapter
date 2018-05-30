using ConsoleApp1.Adapter;
using ConsoleApp1.Source;
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
            Console.WriteLine("Введите радиус отверстия: ");
            int radius_hole = int.Parse(Console.ReadLine());
            RoundHole hole = new RoundHole(radius_hole);
            Console.WriteLine("Укажите радиус вставляемого в отверстие цилиндра: ");
            int radius_peg = int.Parse(Console.ReadLine());
            RoundPeg peg = new RoundPeg(radius_peg);

            if (hole.Fits(peg) == true)
            {
                Console.WriteLine("Вставило норм!");
            }
            else
            {
                Console.WriteLine("Не вставляет!");
            }

            Console.WriteLine("Укажите ширину обьекта квадратной формы: ");
            int width = int.Parse(Console.ReadLine());
            SquarePeg square = new SquarePeg(width);
            SquarePegAdapter adapter = new SquarePegAdapter(square);
            if(hole.Fits(adapter)==true)
            {
                Console.WriteLine("зашло!");
            }
            else
                Console.WriteLine("Не зашло!");
           
        }
    }
}
