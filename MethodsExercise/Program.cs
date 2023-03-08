using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: Story

            //Console.WriteLine("What is your first name?"); //output
            //var firstName = Console.ReadLine(); //input

            //Console.WriteLine("What is your favorite color?"); //output
            //var faveColor = Console.ReadLine(); //input

            //Console.WriteLine("What is an item of clothing?"); //output
            //var clothing = Console.ReadLine(); //input

            //Console.WriteLine("What is a number between 10-40?"); //output
            //var numDays = Console.ReadLine(); //input

            //Console.WriteLine("What is your favorite animal?"); //output
            //var faveAnimal = Console.ReadLine(); //input

            //Console.WriteLine("What is a number between 1-10?"); //output
            //var numTreats = Console.ReadLine(); //input

            //Console.WriteLine($"{firstName} had a lucky {faveColor} {clothing}. " +
            //    $"So lucky, the {clothing} hasn't been washed in {numDays} days." +
            //    $" One day, their pet {faveAnimal} got hold of it. " +
            //    $"After {numTreats} treats, their pet {faveAnimal} fell asleep. " +
            //    $"Upon further investigation, {firstName} realized they were wearing it all along.");

            var sumAnswer = Add(num 1, num2);           
            Console.WriteLine(sumAnswer);

            var productAnswer = Multiply(10, 2);
            Console.WriteLine(productAnswer);


        }

        // Exercise 2:
        public static double Add(int num1, int num2)
        {
           

            double sum = num1 + num2;

            return sum;


        }

        public static double Multiply(int num1, int num2)
        {
            double product = num1 * num2;

            return product;
        }



    }
}


