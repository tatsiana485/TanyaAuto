using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TanyaAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson3_Pifagor();
            //Lesson3_Cos();
            //Lesson4_1();
            //Lesson4_2_1();
            //Lesson4_2_2();
            //Lesson5_1dimentionalArray();
            //Lesson5_1dimentionalArray_invalidTry();
            //Lesson5_multiDimentionalArray();
            //Lesson5_List();
            //Lesson5_2DimentionalArrayWithDiscount();
            //Lesson6_Task1();
            //Lesson6_Task2();
            //Lesson6_Task3();
            //Lesson7();
            //Lesson8_Task1_Call();
            //Lesson8_Task2_Call();
            //Lesson8_Task3_Call();
            //Lesson9_Task1();
            //Lesson9_Task2();
            //Lesson9_Task3();
            //Lesson10();
            //Lesson11_Task1();
            //Lesson11_Task2();
            //Lesson11_Task3();
            //Lesson13();
            //TV tv = new TV();
            //while (true)
            //{
            //    Lesson14(tv);
            //}
            //Lesson15();
            Lesson16();
            //Console.ReadKey();

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

            Console.WriteLine("The discount is   " + shopDiscount[indexShops - 1, indexDays - 1]);
        }

        static void Lesson6_Task1()
        {
            int numbers = 1;
            int multiplier = 3;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + ":" + numbers);
                numbers = numbers + multiplier;
            }
        }

        static void Lesson6_Task2()
        {
            string password;
            do
            {
                Console.WriteLine("Password, please ");
                password = Convert.ToString(Console.ReadLine());
            }
            while (password != "root");
            Console.Write("Success!");
        }

        static void Lesson6_Task3()
        {
            int[] array1 = new int[10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            int[] array2 = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int[] result = new int[10];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = array1[i] + array2[i];
                Console.WriteLine("Result element: " + result[i]);
            }
        }

        static void Lesson7()
        {
            int[] array = { 10, 15, 25, 20, 46, 35, 22, 55, 96, 50, 100 };

            foreach (int k in array)
            {
                if (k >= 20 && k <= 50)
                {
                    Console.WriteLine("Integer numbers:" + k);
                }
            }
        }
        public static void Lesson8_Task1_Call()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please input array element");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Input the number, please: ");
            int compareTo = Convert.ToInt32(Console.ReadLine());

            int[] result;
            result = Lesson8_Task1(numbers, compareTo);

            foreach (int el in result)
            {
                Console.WriteLine(el);
            }
        }

        public static int[] Lesson8_Task1(int[] numbers, int k)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == k)
                {
                    numbers[i] = k * (-1);
                }
            }
            return numbers;
        }


        public static void Lesson8_Task2_Call()
        {
            int number1;
            int number2;
            int number3;

            Console.WriteLine("Input 3 numbers: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine("The MIN among numbers is:" + number1);
            }
            else if (number2 < number3)
            {
                Console.WriteLine("The MIN among numbers is:" + number2);
            }
            else
            {
                Console.WriteLine("The MIN among numbers is:" + number3);
            }
        }

        public static int GetFibonachiElement(int index)
        {
            int firstElement = 1;
            int secondElement = 1;

            if (index == 1 || index == 2)
            {
                return firstElement;
            }

            for (int i = 3; i <= index; i++)
            {
                int result = firstElement + secondElement;
                firstElement = secondElement;
                secondElement = result;
            }
            return secondElement;

        }
        public static void Lesson8_Task3_Call()
        {
            Console.WriteLine("Please input any int number: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int result = GetFibonachiElement(index);
            Console.WriteLine("The Fibonachi element:" + result);
        }

        static void Lesson9_Task1()
        {
            string a = "Nikolay prishel k Olegu, a tam escho odin Nikolay s Nikolayom i Olegom";
            Console.WriteLine(a.Replace("Nikolay", "Oleg"));
        }

        static void Lesson9_Task2()
        {
            string longText = "Today we learnt how to work with string in C#. Main operators and methods, which are used for working with string, were described here.";
            int indexBegin = longText.IndexOf("Main");
            int indexEnd = longText.IndexOf(", were");

            Console.WriteLine(longText.Substring(indexBegin, indexEnd - indexBegin));
        }

        static void Lesson9_Task3()
        {
            string login = "Login1,LOgin2,login3,loGin4";
            login = login.ToLower();
            string[] loginArray = login.Split(',');

            foreach (string el in loginArray)
            {
                Console.WriteLine(el);
            }
        }

        static void Lesson10()
        {
            int[] myIntArray = { 1, 2, 3, 9, 55, 96, 63, 56, 36, 95 };
            string result = "";

            try
            {
                Console.WriteLine("Input the 1st number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the 2nd number:");
                int b = Convert.ToInt32(Console.ReadLine());
                result = "The result is:" + (myIntArray[a] + myIntArray[b]);
            }
            catch (Exception)
            {
                result = "error";
            }
            Console.WriteLine(result);

        }

        static void Lesson11_Task1()
        {
            FileStream newFile = new FileStream("D:\\training\\AUTOMATION\\numbers.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(newFile);
            for (int i = 1; i < 501; i++)
            {
                writer.WriteLine(i + ",");
            }
            writer.Close();
        }

        static void Lesson11_Task2()
        {
            StreamWriter write = new StreamWriter("D:\\training\\AUTOMATION\\colors.txt");

            string[] colors = { "red", "green", "black", "white", "blue" };
            foreach (string el in colors)
            {
                write.WriteLine(el);
            }

            write.Close();
        }

        static void Lesson11_Task3()
        {
            FileStream textFile = new FileStream("D:\\training\\AUTOMATION\\sourcetree\\README.md", FileMode.Open);
            StreamReader reader = new StreamReader(textFile);
          
            int maxLength = 0;

            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                if (line.Length > maxLength)
                {
                  maxLength = line.Length;
                }
            }
            reader.Close();
            Console.WriteLine("The longest line consists of : " + maxLength + " symbols");
            Console.ReadKey();
        }

        static void Lesson13()
        {
            Auto myAuto = new Auto();
            Auto yourAuto = new Auto();

            myAuto.Manufacturer = "BMW";
            myAuto.ProductionCountry = "Germany";
            myAuto.Engine = 2.0;
            myAuto.DoorQuantity = 5;

            yourAuto.ProductionCountry = "Japan";
            yourAuto.Manufacturer = "Mazda";
            yourAuto.Engine = 1.5;
            yourAuto.DoorQuantity = 3;

            Console.WriteLine("My auto main characteristics: produced by " + myAuto.Manufacturer + " born in " + myAuto.ProductionCountry + " and the engine is " + myAuto.Engine + " Litres, with " + myAuto.DoorQuantity + " doors.");
            Console.WriteLine("Your auto main characteristics: produced by " + yourAuto.Manufacturer + " born in " + yourAuto.ProductionCountry + " and the engine is " + yourAuto.Engine + " Litres, with " + yourAuto.DoorQuantity + " doors.");
        }

        static void Lesson14(TV tv)
        {
            Console.WriteLine("Please input channel or + for next or - for prev, ++ for Volume Up and -- for Volume Down and symbol * for mute.");
            string line = Console.ReadLine();

            if (line == "+")
            {
                tv.NextChannel();
                Console.WriteLine("Current channel: " + tv.CurrentChannel);
            }
            else if (line == "-")
            {
                tv.PrevChannel();
                Console.WriteLine("Current channel: " + tv.CurrentChannel);
            }
            else if (line == "++")
            {
                tv.VolumeUp();
                Console.WriteLine("Volume is: " + tv.Volume);
            }
            else if (line == "--")
            {
                tv.VolumeDown();
                Console.WriteLine("Volume is: " + tv.Volume);
            }
            else if (line == "*")
            {
                tv.SetMute();
                Console.WriteLine("Mute is:" + tv.Mute);
            }
            else
            {
                int channel = Convert.ToInt32(line);
                tv.SetChannel(channel);
                Console.WriteLine("Current channel: " + tv.CurrentChannel);
            }

        }

        static void Lesson15()
        {
            Student[] studentArray = new Student[]
            {
                new Student(),
                new Student("Kolya"),
                new Student("Tanya", 7),
                new Student("Keren", 9, true)
            };            

            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.Write("The student info: his name is " + studentArray[i].Name);
                Console.Write(" course is: " + studentArray[i].Course);
                Console.Write(" scolarship: " + (studentArray[i].Scolarship ? "Yes" : "No"));
                Console.WriteLine();
            }
        }
        static void Lesson16()
        {
            TVset tv1 = new TVset();
            Console.WriteLine("Write any volume value from 0 to 100: ");
            tv1.Volume = Convert.ToInt32(Console.ReadLine()); 
                    
            Console.WriteLine(tv1.Volume); 
            Console.ReadKey();
        }
    }
}



        


    
       
