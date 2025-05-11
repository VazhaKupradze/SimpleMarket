using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleMarket
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string Gender;
        public int Age;
        public string PersonalId;


        public void DisplayInfo()
        {

            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Personal ID: {PersonalId}");
            Console.WriteLine("-------------------------------");
        }
    }
}
