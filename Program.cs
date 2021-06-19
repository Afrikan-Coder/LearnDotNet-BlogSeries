using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name, onto the Console: ");
            var expectedName = Console.ReadLine();
            Console.WriteLine($"Hello World {expectedName}, What lesson do you want to learn next?"); 
            
            int chosenLesson = Convert.ToInt16( Console.ReadLine());
            Console.WriteLine($"You have chosen the lesson number:::{chosenLesson} ");
            //Other basic data types
            int myAge = 30;
            bool isProgrammingEasy = true;
            byte myData = 40;
            double mySalaryPerHour = 1200.50;
            float myHeight = 192.75f;
            string myCity = "Cape Town";
            object myCar = new Object() {};
            Console.WriteLine(
                $"Is programming easy ? : {isProgrammingEasy};" +
                $"My age is : {30} ; My data : {40} ; My salary per hour {mySalaryPerHour} ; " +
                $"My height : {myHeight} ; My city : {myCity}; Example object : {myCar}" 

                );
        }
    }
}
