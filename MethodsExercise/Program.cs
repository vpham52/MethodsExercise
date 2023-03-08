using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: Story

            //Console.WriteLine("What is your first name?"); //output
            //var name = Console.ReadLine(); //input

            //Console.WriteLine("What is your favorite color?"); //output
            //var color = Console.ReadLine(); //input

            //Console.WriteLine("What is an item of clothing?"); //output
            //var clothing = Console.ReadLine(); //input

            //Console.WriteLine("What is a number between 10-40?"); //output
            //var days = Console.ReadLine(); //input

            //Console.WriteLine("What is your favorite animal?"); //output
            //var animal = Console.ReadLine(); //input

            //Console.WriteLine("What is a number between 1-10?"); //output
            //var treats = Console.ReadLine(); //input

            //Console.WriteLine($"{name} had a lucky {color} {clothing}. " +
            //    $"So lucky, the {clothing} hasn't been washed in {days} days." +
            //    $" One day, their pet {animal} got hold of it. " +
            //    $"After {treats} treats, their pet {animal} fell asleep. " +
            //    $"Upon further investigation, {name} realized they were wearing it all along.");

            var sumAnswer = Add(2, 4);
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


