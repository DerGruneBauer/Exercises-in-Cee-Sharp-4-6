using System;

namespace C__Exercises_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //NUMBER VARIABLES WITH CONVERT AND CAST
            //Exercise 4 
            Console.WriteLine("Please enter two integers below, one at a time:");
            int userNumber1 = int.Parse(Console.ReadLine());
            int userNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"You chose the numbers, {userNumber1} and {userNumber2}.");
            Console.WriteLine("Here's some cool math for you.");
            Console.WriteLine($"{userNumber1} + {userNumber2} = {userNumber1+userNumber2} \n{userNumber1} - {userNumber2} = {userNumber1-userNumber2}");
            Console.WriteLine($"{userNumber1} * {userNumber2} = {userNumber1*userNumber2} \n{userNumber1} / {userNumber2} = {(double)userNumber1/userNumber2}");


            //Exercise 5
            // Console.WriteLine("Please input your age.");
            // int userAge = int.Parse(Console.ReadLine());
            // Console.WriteLine("How old is your father?");
            // int userFatherAge = int.Parse(Console.ReadLine());
            // Console.WriteLine("How old is your mother?");
            // int userMotherAge = int.Parse(Console.ReadLine());
            // Console.WriteLine($"Your father is {userFatherAge-userAge} years older than you. \nYour mother is {userMotherAge-userAge} years older than you.");


            //Exercise 6 (could use conditional or input to determine country and decimal input preference eg. "," or ".". Should also be built in system to determine country?)
            //Wanted to use decimel for user wage, but unsure of how to mix the two when multiplying a non financial number (hours worked vs amount paid)
            // Console.WriteLine("Please input an hourly wage.");
            // Console.Write("$");
            // double userWage = double.Parse(Console.ReadLine().Replace(".", ","));
            // Console.WriteLine("How many hours do you work in a week?");
            // double userHours = Double.Parse(Console.ReadLine().Replace(".", ","));
            // Console.WriteLine("How many weeks of unpaid vacation do you take a year?");
            // double userVacationWeeks = Double.Parse(Console.ReadLine().Replace(".", ","));
            // double userTotalPay = (((userWage*userHours)*52) - ((userWage*userHours)*userVacationWeeks));
            // Console.WriteLine($"Based on this information and before taxes, you will make ${Math.Round(userTotalPay, 2).ToString().Replace("," , ".")} in one year.");

        }
    }
}
