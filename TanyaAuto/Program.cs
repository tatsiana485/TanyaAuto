using System;
using System.Collections.Generic;

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
            Lesson5_1dimentionalArray();
            Lesson5_1dimentionalArray_invalidTry();
            Lesson5_multiDimentionalArray();
            Lesson5_List();
            Lesson5_2DimentionalArrayWithDiscount();
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

        static void Lesson5_1dimentionalArray()
        {
            int[] dates = new int[4];
            dates[0] = 1;
            dates[1] = 5;
            dates[2] = 25;
            dates[3] = 30;
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Input a number for date");

            int indexDates = Convert.ToInt32(Console.ReadLine());

            if (indexDates < 0 || indexDates > 3)
                Console.WriteLine("The date has limit from 0 to 3");
            else
                Console.WriteLine("Date:" + dates[indexDates]);

            Console.WriteLine("Input a number for day");
            int indexDays = Convert.ToInt32(Console.ReadLine());

            if (indexDays < 0 || indexDays > 6)
                Console.WriteLine("The week is limited from 0 to 6");
            else
                Console.WriteLine("Weekday:" + weekdays[indexDays]);
        }

        static void Lesson5_1dimentionalArray_invalidTry()
        {
            int[] dates = new int[4];
            dates[0] = 1;
            dates[1] = 5;
            dates[2] = 25;
            dates[3] = 30;
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("Input a number for date");
            int indexDates = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date:" + dates[indexDates]);

            Console.WriteLine("Input a number for day");
            int indexDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Weekday:" + weekdays[indexDays]);
        }

        static void Lesson5_multiDimentionalArray()
        {
            int[,] shopDiscount = new int[2, 2] { { 20, 30 }, { 15, 10 } };
        }

        static void Lesson5_List()
        {
            List<string> tlmServices = new List<string>() { "File Manager", "Infrastructure Manager", "Link Manager" };
            tlmServices.Add("Project Manager");
            tlmServices.Add("Purchase");
            tlmServices.Add("TDM");
            tlmServices.Add("Tool Manager");
            tlmServices.Add("ToolScout");

            tlmServices.Insert(4, "Core Service");
            tlmServices.Remove("Purchase");
                     
            Console.WriteLine(tlmServices[0]);
            Console.WriteLine(tlmServices[1]);
            Console.WriteLine(tlmServices[2]);
            Console.WriteLine(tlmServices[3]);
            Console.WriteLine(tlmServices[4]);
            Console.WriteLine(tlmServices[5]);
            Console.WriteLine(tlmServices[6]);
            Console.WriteLine(tlmServices[7]);
        }

        static void Lesson5_2DimentionalArrayWithDiscount()
        {
            int[,] shopDiscount = new int[2, 2] { { 20, 30 }, { 15, 10 } };
            
            Console.WriteLine("Rewe(1) or Edeka(2)? - ");
            int indexShops = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monday(1) or Thursday(2)? - ");
            int indexDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The discount is   " + shopDiscount[indexShops-1, indexDays-1]);
        }
    }
}