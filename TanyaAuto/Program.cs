using System;

namespace TanyaAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson3_Pifagor();
            Lesson3_Cos();
            Console.ReadKey();
        }

        static void Lesson3_Pifagor()
        {
            double a = 5, b = 7;
            double square;

            square = a * b / 2;
            Console.WriteLine("Square: " + square);

            double hypotinuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Hypotinuse: " + hypotinuse);
        }

        static void Lesson3_Cos()
        {
            double a = 5, b = 7;
            double hypotinuse;
            double cos = Math.Cos(90 * Math.PI / 180);
            hypotinuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * cos);
            Console.WriteLine("Hypotinuse:" + hypotinuse);

        }
    }
}