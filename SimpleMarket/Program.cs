using SimpleMarket.Entities;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace SimpleMarket;

public static class Program
{
    private static void Main(string[] args)
    {
        //var person1 = new Person();
        //person1.FirstName = "mazda";

        //var emp = new Employ();
        //emp.FirstName = "emp";

        //Console.WriteLine("person:");
        //person1.DisplayInfo();


        //Console.WriteLine("employ:");
        //emp.DisplayInfo();

        //return;

        while (true)
        {
            var product = CreateProduct();
            product.Name = "name";

            DataBase.Products.Add(product);

            Console.WriteLine("to continue press Y");
            var answer = Console.ReadLine();
            if (answer.ToUpper() != "Y")
            {
                break;
            }
        }

        foreach (var product in DataBase.Products)
        {
            product.CalculateFinalPrice();
            product.DisplayInfo();
        }

        while (true)
        {
            var person = InitPerson();


            DataBase.Persons.Add(person);

            Console.WriteLine("Do you want to add another person?" +
                "If Yes Press Y" +
                "If no Press any bottom");
            var secondAnswer = Console.ReadLine();
            if (secondAnswer.ToUpper() != "Y")
            {
                break;
            }
        }


        foreach (var person in DataBase.Persons)
        {
            person.DisplayInfo();
        }

    }

    public static Person InitPerson()
    {
        Console.WriteLine("Enter First Name:");
        var firstName = Console.ReadLine();


        Console.WriteLine("Enter Last Name:");
        var lastName = Console.ReadLine();


        Console.WriteLine("Enter Gender:");
        var gender = Console.ReadLine();


        Console.WriteLine($"Enter {firstName}'s Age:");
        var age = Console.ReadLine();

        Console.WriteLine($"Enter {firstName}'s Personal ID:");
        var personalId = Console.ReadLine();

        var person = CreatePerson(firstName, lastName, gender, int.Parse(age), personalId);

        return person;
    }

    public static Person CreatePerson(string firstName, string lastName, string gender, int age, string personalId)
    {
        var person = new Person()
        {
            FirstName = firstName,
            LastName = lastName,
            Gender = gender,
            Age = age,
            PersonalId = personalId
        };

        return person;
    }


    public static Product CreateProduct()
    {
        var product = new Product();

        Console.WriteLine("Enter product name:");
        var name = Console.ReadLine();
        product.Name = name;


        Console.WriteLine("Enter product category");
        var category = Console.ReadLine();
        product.Category = category;


        Console.WriteLine("Enter product price");
        var price = Console.ReadLine();
        product.Price = decimal.Parse(price);


        Console.WriteLine("Enter product discount");
        var discount = Console.ReadLine();
        product.Discount = decimal.Parse(discount);


        Console.WriteLine("Enter product Quantity");
        var quantity = Console.ReadLine();
        product.Quantity = int.Parse(quantity);

        return product;
    }


}



