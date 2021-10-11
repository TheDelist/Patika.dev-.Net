using System;
using System.Collections;
namespace odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //q1();
            //q2();
            q3();
        }
        public static void q1()
        {
            ArrayList primeList = new ArrayList();
            ArrayList others = new ArrayList();
            ArrayList inputList = new ArrayList();
            ArrayList arlist = new ArrayList() { 2, 3, 5, 7, 11, 14, 17, 19, 23, 29, 31, 38, 42, 43, 47, 53, 59, 61, 67, 71 };
            for (int i = 0; i < 20; i++)
            {
                string ar = Console.ReadLine();
                int Num = 0;
                bool isNum = int.TryParse(ar, out Num);
                if (isNum && Num > 0)
                {
                    inputList.Add(Num);
                }
                else
                {
                    Console.WriteLine("please enter NUMBER");
                    System.Environment.Exit(0);
                }




            }


            foreach (int item in arlist)
            {
                if (isPrime(item))
                {
                    primeList.Add(item);
                }
                else
                {
                    others.Add(item);
                }
            }
            primeList.Sort();
            primeList.Reverse();
            foreach (int item in primeList)
            {
                Console.WriteLine(item);
            }
            others.Sort();
            others.Reverse();
            foreach (int item in others)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("prime " + primeList.Count);
            Console.WriteLine("not prime " + primeList.Count);
            Console.WriteLine("average " + (primeList.Count + others.Count) / 2);


        }
        public static bool isPrime(int n)
        {
            int i, m = 0;

            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void q2()
        {
            int[] arlist = new int[20] { 2, 3, 5, 7, 11, 14, 17, 19, 23, 29, 31, 38, 42, 43, 47, 53, 59, 61, 67, 71 };
            int sumMin = 0;
            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < 3; i++)
            {

                int min = int.MaxValue;

                int minIndex = 0;
                for (int j = 0; j < arlist.Length; j++)
                {
                    if (arlist[j] > max)
                    {
                        max = arlist[j];
                        maxIndex = j;
                    }
                    if (arlist[j] < min && arlist[j] >= 0)
                    {
                        min = arlist[j];
                        minIndex = j;
                    }
                }
                arlist[maxIndex] = -1;
                arlist[minIndex] = -2;

                sumMin += min;


            }
            Console.WriteLine("average max=" + max / 3);
            Console.WriteLine("average min=" + sumMin / 3);
            Console.WriteLine("average =" + (max / 3 + sumMin / 3));


        }
        public static void q3()
        {
            string senteces = "oley be sonunda internetim gelecek allahım";
            senteces.ToLower();
            char[] ar = senteces.ToCharArray();
            char[] arr= {'a','e','i','o','u'};
            ArrayList op=new ArrayList();
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(ar[i]==arr[j]){
                        op.Add(arr[j]);
                    }
                }
            }
           foreach (var item in op)
           {
               Console.WriteLine(item);
           }

        }



    }
}
