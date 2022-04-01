using System;
namespace SChekalinModuleCsharp3App
{
    class Prorgamm
    {
        static void Main(string[] args)
        {
            string MyName = "Sergei";
            byte MyAge = 50;
            bool HaveIApet = true;
            double MyShoeSize = 42.5;

            Console.WriteLine($"My name is {MyName}");
            Console.WriteLine($"MyAge {MyAge}");
            Console.WriteLine($"Do I have a pet? {HaveIApet}");
            Console.WriteLine($"My shoe size is {MyShoeSize}");
        }
    }
}