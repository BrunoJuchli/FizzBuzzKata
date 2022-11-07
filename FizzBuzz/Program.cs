// See https://aka.ms/new-console-template for more information

using FizzBuzz;

foreach (var entry in FizzBuzzGenerator.GenerateUntil(100))
{
    Console.WriteLine(entry);    
}

