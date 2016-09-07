using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("What is your first name? ");
            string firstName;
            firstName = System.Console.ReadLine();
            System.Console.Write("What is your middle initial? ");
            string middleInitial;
            middleInitial = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            string lastName;
            lastName = System.Console.ReadLine();

            System.Console.Write("What is your height in feet? ");
            int heightFeet;
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("What is your height in inches? ");
            double heightInches;
            heightInches = double.Parse(System.Console.ReadLine());
            double feetInches = heightFeet * 12;
            double totalInches = feetInches + heightInches;
            double totalHeightCM = totalInches * 2.54;

            System.Console.Write("What is your age? ");
            int age;
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen? ");
            bool canVote = age >= 18;

            canVote = System.Console.ReadLine().ToLower().StartsWith("y");

            System.Console.WriteLine("Your full name: " + firstName + " " + middleInitial + ". " + lastName);
            System.Console.WriteLine("Your total height in centimeters: " + " " + totalHeightCM + "CM");
            System.Console.WriteLine("You are eligible to vote: " + " " + canVote);

            System.Console.Write("Press any key to continue. ");
            System.Console.ReadKey();
        }
    }
}
