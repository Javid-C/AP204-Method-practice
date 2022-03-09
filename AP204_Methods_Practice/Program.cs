using System;

namespace AP204_Methods_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            //Divideby7(num);

            //Console.WriteLine("Please enter first number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter operation");
            //char op = Convert.ToChar(Console.ReadLine());
            //Calculator(num1, num2, op);

            //Range(75);

            //Season(8);

            Bank(1000, 3);
        }

        public static void Divideby7(int num)
        {
            if (num % 7 == 0)
            {
                Console.WriteLine(num + " 7-ye bolunur");
            }
            else
            {
                int remainder = num % 7;
                if (remainder > 3)
                {
                    while (num % 7 != 0)
                    {
                        num++;
                    }
                }
                else
                {
                    while (num % 7 != 0)
                    {
                        num--;
                    }
                }
                Console.WriteLine(num);

            }
        }

        public static void Calculator(int num1, int num2, char op)
        {
            switch (op)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '/':
                    Console.WriteLine(num1 / num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                default:
                    Console.WriteLine("Please enter valid operation");
                    break;
            }
        }

        public static void Range(int num)
        {
            int count = 1;
            if (num < 50 && num > 0)
            {
                for (int i = 4; i < num; i++)
                {
                    if (i % 3 == 0)
                    {
                        count++;
                    }
                }
            }
            else if (num >= 50 && num <= 100)
            {
                for (int i = 6; i <= num; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public static void Season(int num)
        {
            switch (num)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Qis");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Yaz");
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa duzgun eded daxil edin");
                    break;
            }
        }

        public static void Bank(int salary, int month)
        {
            int payment = salary / month;
            int remainder = salary % month;
            int lastPayment = payment + remainder;

            for (int i = 1; i <= month; i++)
            {
                if (i == month)
                {
                    Console.WriteLine(i + ". ay odenish " + lastPayment);
                }
                Console.WriteLine(i + ". ay odenish " + payment);
            }
        }
    }
}
