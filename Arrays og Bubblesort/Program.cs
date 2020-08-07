using System;

using System.Linq;

using System.Security.Principal;

using System.Text;



namespace Practice

{

    class Program

    {

        static void Main(string[] args)

        {   //declaring array and random number generator

            int[] tal = new int[100];

            Random random = new Random();

            //for loop to create 100 random numbers and print them to the console

            for (int i = 0; i < tal.Length; i++)

            {

                int randomNumber = random.Next(0, 1000);

                tal[i] = randomNumber;

                Console.WriteLine(tal[i]);

            }   //for loop to sort array

            for (int j = 0; j < (tal.Length - 1) - j; j++)

            {

                if (tal[j] > tal[j] + 1)

                {

                    int temp = tal[j + 1];

                    tal[j + 1] = tal[j];

                    tal[j] = temp;

                    Console.WriteLine(tal[j]);

                }

                Array.Reverse(tal); //reverses array

            }

            Console.ReadKey(); //keeps console up

        }

    }

}