using System;

namespace MethodsExercise
{
    public class Program
    {

        // Exercise 1: Story

        public static void MadLib()
        {
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
        }

        static void Main(string[] args)
        {
            // Method Call - Exercise 1
            //MadLib();


            // Exercise 2

            var sumAnswer = Add(32.5, 54.6);
            Console.WriteLine(sumAnswer);

            var differenceAnswer = Subtract(7,2);
            Console.WriteLine(differenceAnswer);

            var productAnswer = Multiply(56.3,22.9);
            Console.WriteLine(productAnswer);

            var divisionAnswer = Divide(8, 6);
            Console.WriteLine(divisionAnswer);

        }

        //Exercise 2:
        public static double Add(double num1, double num2)
        {
            return num1 + num2; 
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {            
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2; 
        }

        

    }
}


