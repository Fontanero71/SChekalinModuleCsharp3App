using System;
namespace SChekalinModuleCsharp3App
{
    class Prorgamm
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string MyName = Console.ReadLine();
            Console.Write("Enter your age: ");
            byte MyAge = checked( (byte) int.Parse(Console.ReadLine()));
            Console.WriteLine($"Your name is {MyName} and age is {MyAge}.");
            Console.Write("Enter your birthday: ");
            string MyBirthday = Console.ReadLine();
            Console.WriteLine($"Your birthday is {MyBirthday}.");
        }
    }
}