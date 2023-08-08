using System;
using System.Linq;


namespace SF_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string firstName, string lastName, int age, bool isHasPet, int petsAmount, string[] petNames, int favColorsAmount, string[] favColorNames )User;
            Console.WriteLine("Enter the first name");
            User.firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            User.lastName = Console.ReadLine();
            User.age = SetIntFromConsole("Enter UR age");
            Console.WriteLine("Do U have a pet?");
            User.isHasPet = (Console.ReadLine()).ToLower() == "yes" ? true : false;
            if (User.isHasPet)
            {
                User.petsAmount = SetIntFromConsole("How many pets do U have?");
                User.petNames = FillArray("Enter the name of UR pet number ", User.petsAmount);
            }
            else 
            {
                User.petsAmount = 0;
                User.petNames = new string[0];
            }
            User.favColorsAmount = SetIntFromConsole("How many colors do U like?");
            User.favColorNames = FillArray ("Enter the name of UR favorite colors number ", User.favColorsAmount);
            ShowData((User.firstName,User.lastName,User.age,User.isHasPet,User.petsAmount, User.petNames, User.favColorsAmount,User.favColorNames));
            Console.ReadKey();
        }
        static int SetIntFromConsole(string stringToConsole) 
        {
            const string allNumbers = "0123456789";
            string tempString ="";
            while (true)
            {
                Console.WriteLine(stringToConsole);
                tempString = Console.ReadLine();
                tempString.TrimEnd();
                if (tempString.Length < 4)
                {
                    for (int i = 0; i < tempString.Length; i++)
                    {
                        if (!allNumbers.Contains(tempString[i])) break;
                        if(i == (tempString.Length - 1) & tempString != "0") return int.Parse(tempString);
                    }
                    Console.WriteLine("U enter the incorrect value");
                }
            }
        }

        static string[] FillArray(string stringToConsole, int arrayLength)
        {
            var items = new string[arrayLength];  
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(stringToConsole + (i+1));
                items[i]=Console.ReadLine();
            }
            return items;
        }

        static void ShowData((string firstName, string lastName, int age, bool isHasPet, int petsAmount, string[] petNames, int favColorsAmount, string[] favColorNames) User)
        {
            Console.WriteLine("First Name: " +User.firstName);
            Console.WriteLine("Last Name: " + User.lastName);
            Console.WriteLine("Age: " + User.age);
            if (User.isHasPet)
            {
                Console.WriteLine("Number of pets: " + User.petsAmount);
                Console.WriteLine("Pets names:");
                for (int i = 0;i < User.petsAmount; i++) 
                {
                    Console.WriteLine("\t" + User.petNames[i]);
                }
            }
            else
            {
                Console.WriteLine("No pets");
            }
            Console.WriteLine("Number of favorite colors: " + User.favColorsAmount);
            Console.WriteLine("Favorite colors:");
            for (int i = 0; i < User.favColorsAmount; i++)
            {
                Console.WriteLine("\t" + User.favColorNames[i]);
            }
        }
    }
}
