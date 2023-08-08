using System;
using System.Linq;


namespace SF_56
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
            User.isHasPet = Console.ReadLine().ToLower() == "yes" ? true : false;
            if (User.isHasPet)
            {
                User.petsAmount = SetIntFromConsole("How many pets do U have?");
                User.petNames = new string[User.petsAmount];
                for (int i = 0; i < User.petNames.Length; i++)
                {
                    Console.WriteLine("Enter the name of UR pet number " + (i + 1));
                    User.petNames[i] = Console.ReadLine();
                }
            }
            else 
            {
                User.petsAmount = 0;
                User.petNames = new string[0];
            }
            User.favColorsAmount = SetIntFromConsole("How many colors do U like?");
            User.favColorNames = new string[User.favColorsAmount];
            for (int i = 0; i < User.favColorNames.Length; i++)
            {
                Console.WriteLine("Enter the name of UR favorit color number " + (i + 1));
                User.favColorNames[i] = Console.ReadLine();
            }
            ShowData((User.firstName,User.lastName,User.age,User.isHasPet,User.petsAmount, User.petNames, User.favColorsAmount,User.favColorNames));
            Console.ReadKey();
        }
        static int SetIntFromConsole(string stringToConsole) 
        {
            while (true)
            {
                Console.WriteLine(stringToConsole);
                string tempString = Console.ReadLine().Trim();
                if (int.TryParse(tempString,out int intValue) & intValue > 0)
                {
                    return intValue;
                }
                Console.WriteLine("U entered the incorrect value");
            }
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
