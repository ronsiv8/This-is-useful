using System;

namespace ConsoleApp19
{
    class Program
    {
        //static int getMinutes(int hr, int min)
        //{
        //    return hr * 60 + min;
        //}
        //static int getGap(int hr1, int hr2, int min1, int min2)
        //{
        //    return getMinutes(hr2, min2) - getMinutes(hr1, min1);
        //}
        //static void Main(string[] args)
        //{
        //    int hr = int.Parse(Console.ReadLine());
        //    int min = int.Parse(Console.ReadLine());
        //    Console.WriteLine("total in min:" + getMinutes(hr,min));
        //    int hr2 = int.Parse(Console.ReadLine());
        //    int min2 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("gap in minutes:" + getGap(hr,hr2,min,min2));
        //    int largestDay = 0; int largestWork = 0;
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        hr = int.Parse(Console.ReadLine());
        //        min = int.Parse(Console.ReadLine());
        //        hr2 = int.Parse(Console.ReadLine());
        //        min2 = int.Parse(Console.ReadLine());
        //        int currentWork = getGap(hr, hr2, min, min2);
        //        if (currentWork > largestWork)
        //        {
        //            largestDay = i;
        //        }
        //    }
        //    Console.WriteLine(largestDay);
        //}
        static int thing()
        {
            bool broken = false; int lastDigit = 11;
            int currentNum = int.Parse(Console.ReadLine());
            int ChangeNum = currentNum;
            while (currentNum != 0)
            {
                int currentDigit = currentNum % 10;
                currentNum /= 10;
                ChangeNum = currentNum;
                while(ChangeNum != 0)
                {
                    int digitCheck = ChangeNum % 10;
                    ChangeNum /= 10;
                    if (currentDigit == digitCheck)
                    {
                        broken = true;
                    }
                }
            }
            if (broken) return 0; else return 1;
        }
        static void Main()
        {
            Console.WriteLine(thing());
        }
    }
}
