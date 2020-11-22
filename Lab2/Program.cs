using System;

namespace Lab2 {
    class Program {
        static void Main(string[] args) {

            RollDice();
            PrintNumbers(num1: 1, num2: 2, num3: 3);
            Average(1, 2, 3, 4, 5, 6);

        }

        //optional parameter example
        public static void RollDice(int sides = 6) {
            Random random = new Random();
            Console.WriteLine(random.Next(1, sides + 1));
        }

        //named parameter example
        public static void PrintNumbers(int num2, int num3, int num1) {
            Console.WriteLine("{0} {1} {2}", num1, num2, num3);
        }

        //variable number of parameters example
        public static void Average(params int[] numbers) {
            double total = 0;
            foreach (int number in numbers) {
                total += number;
            }
            Console.WriteLine(total / (double)numbers.Length);
        }

    }
}
