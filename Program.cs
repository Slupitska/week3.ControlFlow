using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personality test
            //приложение просит пользователя ввести его любимый цвет
            //и на основе введенного значения консоль показывает пользователю некоторую обратную связь
            //red - you are so romantic
            //blue - you are a workaholic
            //green - you care about the environment
            //любой другой цвет - you are a {userInput} unicorn

            Console.WriteLine("Please enter your favorite color:");
            string userInput = Console.ReadLine().ToLower(); //RED/reD/ReD/rED --> red

            if(userInput == "red")
            {
                Console.WriteLine("You are so romantic.");
            }
            else if(userInput == "blue")
            {
                Console.WriteLine("You are a workaholic.");
            }
            else if(userInput == "green")
            {
                Console.WriteLine("You care about the environment.");
            }
            else
            {
                Console.WriteLine($"You are a {userInput} unicorn.");
            }
            
            Console.WriteLine("Have a nice day.");
        }
    }
}
 