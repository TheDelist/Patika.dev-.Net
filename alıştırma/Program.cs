using System;

namespace alıştırma
{
    class Program
    {
        static void Main(string[] args)
        {
            int b=5;
            decimal a=b;
            try
            {   Console.WriteLine("sayı giriniz");
               //  int c=int.Parse(Console.ReadLine());
               //  Console.WriteLine("girmiş olduğunuz sayı"+c);
               int time=DateTime.Now.Hour;
               string r=time>6 && time<12?"günaydın" : time>13?"öğleden sonra":"öğlen gibi";
               Console.WriteLine(r);
            }
            catch (System.Exception)
            {
                
                throw;
            }
            finally{
                Console.WriteLine("oley");
            }
        }
    }
}
