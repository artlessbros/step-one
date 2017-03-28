using System;

namespace StepOne
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("What's your name? ");
			var name = Console.ReadLine();
			Console.WriteLine("Hello {0}!", name);
		}
    }
}