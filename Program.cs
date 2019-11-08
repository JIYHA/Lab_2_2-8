using System;

namespace Лаба_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");                               //#2 ind
            int N = Convert.ToInt32(Console.ReadLine());

            if ( N > 0 && N < 100001)
            {
                for ( int i = 0; i < N; i++)
                if (Math.Pow(3, i) == N)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("You N invalid");
            }

            //int a = Convert.ToInt32(Console.ReadLine());                     #2
            //double Pisum = 0;
            //bool flag = true;
            //for (int i = 1; 1 < a; i += 2)
            //{
            //    if (flag)
            //    {
            //        Pisum += 1 / i;
            //    }
            //    else
            //    {
            //       Pisum -= 1 / i;
            //    }
            //    flag = !flag;
            //}
            //Pisum *=4;
            //Console.WriteLine(Pisum);

            //Console.WriteLine("Опять решать сколько там цисел? Хозяин, я устал");      #3
            //int f0 = 1, f1 = 1, fi = 0, k = 0;
            //for (int i = 0; i < 20; i++) //выполняется при 18//
            //{
            //fi = f0 + f1;
            //f0 = f1;
            //f1 = fi;
            //if (fi > 999 && fi < 10000)
            //k++;
            //}
            //Console.Write("Их количество = " + k);

            /*Console.WriteLine("You X");                               #4
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You Q");
            double q = Convert.ToDouble(Console.ReadLine());
            double cosX = 1;
            for (int i = 0, grade = 2; i < q; i++, grade += 2)
            {
                int Fa = grade;
                int b = Fa;
                for (long a = 1; a < b; b--)
                {
                    Fa *= b;
                }  
                int n = i + 1;
                if (n % 2 == 0)
                    cosX += Math.Pow(x, grade) / Fa;
                if (n % 2 != 0)
                    cosX -= Math.Pow(x, grade) / Fa;
            }
            Console.WriteLine(cosX); */
            }
           


            //Console.WriteLine("Chislo");                                                #5
            //int N = Convert.ToInt32(Console.ReadLine());
            //
            //for (int x = 0; x < N; x++)
            //  {
            //  for (int y = 0; y < N; y++)
            //  { 
            //      for (int z = 0; z < N; z++)
            //      {
            //      if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N)
            //      Console.WriteLine(x + " " + y + " " + z);
            //      }
            //  }
            //  }
            //Console.WriteLine("No such combinations!")


            //Console.WriteLine("1-100");                                #6
            //int N = Convert.ToInt32(Console.ReadLine());
            //
            //if (N < 101 && N > 0)
            //{
            //    if (N == 11 || N == 12 || N == 13 || N == 14 || N == 15 || N == 16 || N == 17 || N == 18 || N == 19 || N % 10 > 4 || N % 10 == 0)
            //    {
            //        Console.WriteLine(N + "лет"); 
            //    }
            //    if (N % 10 == 1)
            //    {
            //        Console.WriteLine(N + "год");
            //    }
            //    if (N % 10 > 1 && N % 10 < 5)
            //    {
            //       Console.WriteLine(N + "года");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Siriesly?");
            //}


            //Console.WriteLine("Введите координаты А");                       //#1 ind
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координаты В");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //
            //if (x1 == 0 || y1 == 0 || x2 == 0 || y2 == 0)
            //{
            //    Console.WriteLine("Zero coord");
            //}
            //else
            //{
            //if (x1 < 0 && x2 < 0 || y1 < 0 && y2 < 0)
            //{
            //Console.WriteLine("true");
            //}
            //else if (x1 > 0 && x2 > 0 || y1 < 0 && y2 < 0)
            //{
            //Console.WriteLine("true");
            //}
            //else if (x1 < 0 && x2 < 0 || y1 > 0 && y2 > 0)
            //{
            //Console.WriteLine("true");
            //}
            //else if (x1 > 0 && x2 > 0 || y1 > 0 && y2 > 0)
            //{
            //Console.WriteLine("true");
            //}
            //else
            //{
            //Console.WriteLine("false");
            //}
            //}
        }
    }
}
