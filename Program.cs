using System;
using System.Text;

namespace Lesson10_3PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson10_3PasswordGenerator!");

            PasswordGenerator passwordGenerator1 = new PasswordGenerator();
            Console.WriteLine($"password: {passwordGenerator1.CreatePassword()}");

            PasswordGenerator passwordGenerator2 = new PasswordGenerator(":)TheAmazonClassInCharlotteTakingC#Rocks!", 2);
            Console.WriteLine($"password 2: {passwordGenerator2.CreatePassword()}");

            PasswordGenerator passwordGenerator4 = new PasswordGenerator(":()TheAmazonClassInCharlotteTakingC#RockAndAreGreatCoders!", 4);            
            Console.WriteLine($"password 4: {passwordGenerator4.CreatePassword()}");

            PasswordGenerator passwordGenerator6 = new PasswordGenerator(":^)TheAmazonClassInCharlotteTakingC#RockAndWillChangeTheWorld!", 6);
            Console.WriteLine($"password 6: {passwordGenerator6.CreatePassword()}");

            passwordGenerator4 = new PasswordGenerator("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 4);

            string FirstSet = passwordGenerator4.CreatePassword();

            string SecondSet = passwordGenerator4.CreatePassword();

            string ThirdSet = passwordGenerator4.CreatePassword();

            string FourthSet = passwordGenerator4.CreatePassword();

            Console.WriteLine($"4 Part Hash: {FirstSet} - {SecondSet} - {ThirdSet} - {FourthSet}");

        }
    }
}
