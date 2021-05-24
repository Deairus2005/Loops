using System;

namespace LoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("LOOPING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Print Numbers in Reverse Order");
                Console.WriteLine("2. Reverse Counting");
                Console.WriteLine("3. Print the Square of Even Numbers");
                Console.WriteLine("4. Guess the Magic Number");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        NumbersInReverse();
                        break;
                    case "2":
                        ReverseCounting();
                        break;
                    case "3":
                        SquareOfEvenNumbers();
                        break;
                    case "4":
                        GuessMagicNumber();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void NumbersInReverse()
        {
            // Print out numbers from 5 to 1.

            Console.Clear();
            Console.WriteLine("PRINT NUMBERS IN REVERSE ORDER\n");

            // Enter your solution here

            int i = 5;
            while (i >= 1)
            {
                Console.WriteLine(i);

                i--;
            }
           
            
                
          


             

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // Enter your solution here



            Console.WriteLine("Enter A Number Between 1 And 20");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber >= 1 && userNumber <= 20){
            
                for(int i = userNumber; i > 0; i--)
                {
                    Console.WriteLine(i);

                }
                
            }
            else
            {
                Console.WriteLine("Enter A number between 1 and 20");
            }



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SquareOfEvenNumbers()
        {
            // Print the squares (the number multiplied by itself) for even numbers between 1-9. For the odd numbers, just print them.

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // Enter your solution here

            //2,4,6,8 = even
            // 1,3,5,7,9 = odd
            // 9 executions (conditional= done)

            for( int i = 1; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i * i);
                }
                else if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            //
            // Enter your solution here

            Console.WriteLine("Enter A Number");
            bool get_it_Right = true;

            while (get_it_Right) 
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput % 3 == 0) {

                    get_it_Right = false;

                    Console.WriteLine("You Win ");
            }
                else
                
                    Console.WriteLine("Try again");
                
            }
            

                
              



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
