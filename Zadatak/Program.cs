using System;

namespace Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine("Enter number of task: ");
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
            var task = Console.ReadLine();

            if (task == "1")
            {
                Console.WriteLine("Enter number: ");
                var val = Console.ReadLine();
                Console.WriteLine($"Result: {p.Task1(val)}");
                return;
            }

            if (task == "2")
            {
                Console.WriteLine("Enter text: ");
                var val2 = Console.ReadLine();
                Console.WriteLine("Enter shift step: ");
                var step = Console.ReadLine();
                Console.WriteLine($"Task 2: {p.Task2(val2, Convert.ToInt32(step))}");
            }
        }

        public string Task2(string input, int step)
        {
            var lowerCase = input.ToLower();
            var result = "";

            var letters = lowerCase.ToCharArray();

            var realStep = step % 26;

            foreach (var letter in letters)
            {
                var x = Convert.ToInt32(letter);

                if (x >= 97 && x <= 122)
                {
                    var y = x + realStep;

                    if (y > 122)
                    {
                        x = y % 123 + 97;

                    }
                    else
                    {
                        x = y % 97 + 97;
                    }
                }
                result += Convert.ToChar(x);
            }

            return result;
        }

        public int Task1(string input)
        {
            var numbers = input.ToCharArray();
            var result = 0;
            foreach (var number in numbers)
            {
                result += CalculateFactoriel(Convert.ToInt32(new string(number, 1)));
            }
            return result;
        }

        public int CalculateFactoriel(int number)
        {
            if (number <= 0)
            {
                return 1;
            }
            var result = 1;

            while (number > 0)
            {
                result *= number;
                number--;
            }

            return result;
        }
    }
}
