using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = new MyDelegate(LenghtCircle);
            myDelegate += SquareCircle;
            myDelegate += VolumeBall;
            myDelegate?.Invoke(r);
            Console.ReadKey();

        }

        static double LenghtCircle(double R)
        {
            double D = 2 * Math.PI * R;
            Console.WriteLine($"Длинна окружности равна {D:f2}");
            return D;
        }
        static double SquareCircle(double R)
        {
            double S = Math.PI * R * R;
            Console.WriteLine($"Площадь круга равна {S:f2}");
            return S;
        }
        static double VolumeBall(double R)
        {
            double V = 4 * Math.Pow(R, 3) * Math.PI / 3;
            Console.WriteLine($"Объем шара равен {V:f2}");
            return V;
        }

    }
}
