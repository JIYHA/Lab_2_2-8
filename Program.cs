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

           /* Console.WriteLine(Fact(5));
            double x = Convert.ToDouble(Console.ReadLine());
            double q = Convert.ToDouble(Console.ReadLine());
            double cos = 1;
            bool plus = false;
            int k = 1;
            for (int i = 2; ; i += 2, plus = !plus)
            {
                double c = Math.Pow(x, i);
                double z = Fact(i);
                double sum = c / z;
                if (plus)
                {
                    cos += sum;

                }
                else
                {
                    cos -= sum;
                }
                k++;
                double y = Math.Abs(sum);
                if (y < q)
                    break;
            }
            Console.WriteLine(cos);
            Console.WriteLine(k);*/
           


            //Console.WriteLine("Chislo");                                                #5
            //int N = Convert.ToInt32(Console.ReadLine());
            //bool flag = true;
            //for (int x = 0; x < N; x++)
            //  {
            //  for (int y = 0; y < N; y++)
            //  { 
            //      for (int z = 0; z < N; z++)
            //      {
            //      if (Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3) == N)
            //      Console.WriteLine(x + " " + y + " " + z);
            //      flag = false;
            //      }
            //  }
            //  }
            //  if ( flag )
            //Console.WriteLine("No such combinations!")


            /*Console.WriteLine("1-100");                                #6
            int N = Convert.ToInt32(Console.ReadLine());
            if (N >= 11 && N <= 14)
            {
                Console.WriteLine(N + "лет");
            }
            else {

                int val = N % 10;

            switch (val)
            {

                case 1: Console.WriteLine(N + "год"); break;
                case 2:
                case 3:
                case 4: Console.WriteLine(N + "года"); break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0: Console.WriteLine(N + "лет"); break;*/


            }


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
            //if (x1 < 0 && x2 < 0 && y1 < 0 && y2 < 0)
            //{
            //Console.WriteLine("true");
            //}
            //else if (x1 > 0 && x2 > 0 && y1 < 0 && y2 < 0)
            //{
            //Console.WriteLine("true");
            //}
            //else if (x1 < 0 && x2 < 0 && y1 > 0 && y2 > 0)
            //{
            //Console.WriteLine("true");
            //}
            //else if (x1 > 0 && x2 > 0 && y1 > 0 && y2 > 0)
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
