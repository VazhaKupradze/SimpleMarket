using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace SimpleMarket;

public static class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[]
        {
            1,2,3,4,5
        };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}

        //int j = 0;

        //while (j < numbers.Length)
        //{
        //    Console.WriteLine(numbers[j]);
        //    j++;
        //}

        foreach (int number in numbers)
        {
            if (number == 3)
            {
                break;
            }
            Console.WriteLine(number);
        }
    }

}



