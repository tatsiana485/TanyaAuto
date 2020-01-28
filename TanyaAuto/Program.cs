using System;

namespace TanyaAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson3_Pifagor();
            Lesson3_Cos();
            Lesson4_1();
            Lesson4_2_1();
            Lesson4_2_2();
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

        static void Lesson4_1()
        {
            int localGoals, guestGoals;
            Console.WriteLine("Locals:");
            localGoals = Convert.ToInt32(Console.ReadLine());
            if (localGoals < 0)
            {
                Console.WriteLine("Goals cannot be negative");
                return;
            }
            
            Console.WriteLine("Guests:");
            guestGoals = Convert.ToInt32(Console.ReadLine());
            if (guestGoals < 0)
            {
                Console.WriteLine("Goals cannot be negative");
                return;
            }

            if (localGoals > guestGoals)
                Console.WriteLine("Locals won!!!");
            else if (localGoals < guestGoals)
                Console.WriteLine("Guests won!!!");
            else
                Console.WriteLine("Dead Head!!!");
            Console.ReadKey();
        }

        static void Lesson4_2_1()
        {
            int a;
            Console.WriteLine("Input any numeric value:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a % 3 == 0 && a % 7 == 0 ? "Multiple of 7 and 3" : "Not multiple of 7 and 3");
            Console.ReadKey();
        }

        static void Lesson4_2_2()
        {
            int a;
            Console.WriteLine("Input any numeric value");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0 && a % 7 == 0)
                Console.WriteLine("Multiple of 7 and 3");
            else
                Console.WriteLine("Not multiple of 7 and 3");
            Console.ReadKey();
        }
    }
}