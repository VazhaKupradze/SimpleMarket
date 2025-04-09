using System;

namespace SimpleMarket;

public static class Program
{
    private static void Main(string[] args)
    {
        // homeworkOne
        int productPrice = 500;
        float tax = productPrice * 18 / 100;
        float totalPrice = tax + productPrice;
        Console.WriteLine(totalPrice);
    }
}