using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // one();
            //two();
           // third();
            fourth();


        }
        public static void one()
        {
            // 1.
            Console.WriteLine(" please enter positive number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(" please enter " + number + " positive number");
            int[] numberInputs = new int[number];
            for (int i = 0; i < number; i++)
            {
                numberInputs[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in numberInputs)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void two()
        {
            Console.WriteLine(" please enter 2 positive number");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int[] numberInputs = new int[numberOne];
            Console.WriteLine(" please enter " + numberOne + " positive number");
            for (int i = 0; i < numberOne; i++)
            {
                numberInputs[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in numberInputs)
            {
                if (item == numberTwo || item % numberTwo == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void third()
        {
            Console.WriteLine(" please enter positive number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(" please enter " + number + " string");
            string[] numberInputs = new string[number];
            for (int i = 0; i < number; i++)
            {
                numberInputs[i] = Console.ReadLine();
            }
            for (int i = numberInputs.Length - 1; i >= 0; i--)
            {
                Console.Write(numberInputs[i]);
            }
        }
        public static void fourth(){
             Console.WriteLine(" please enter  sentences");
            string sentence = Console.ReadLine();
          string[] arr=sentence.Split(" ");
            Console.WriteLine("Word count:"+arr.Length);
             Console.WriteLine("Word count:"+sentence.Length);
        }

    }
}
