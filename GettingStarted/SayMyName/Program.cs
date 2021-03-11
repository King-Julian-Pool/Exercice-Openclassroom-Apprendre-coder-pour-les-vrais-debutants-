using System;

namespace SayMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you ?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " !");
            Console.WriteLine("When were you born ?");
            string year = Console.ReadLine();
            int yearnum = int.Parse(year);
            int age = DateTime.Now.Year - yearnum;
            Console.WriteLine("You are " + age.ToString() + " years old");
            if (age < 40)
            {
                Console.WriteLine("Tu es un BG");
            }
            else
            {
                Console.WriteLine("Tu est un vieux BG");
            }
        }
    }
}
