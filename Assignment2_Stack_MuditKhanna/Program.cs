namespace Assignment2_Stack_MuditKhanna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray = new int[5];
            Stack<int> myStack = new Stack<int>();
            int stepsTaken = 0;
            int score = 0;

            //adds random numbers to the array
            for (int i = 0; i < 5; i++)
            {
                myArray[i] = random.Next(1, 49);
            }

            //pushes all the numbers of the array to the stack
            for (int i = 0; i < 5; i++)
            {
                myStack.Push(myArray[i]);
            }

            //sorts the array
            Array.Sort(myArray);

            Console.WriteLine("Creating 5 random Numbers..");

            //first loop is till the stack doesnt contain only 1 element
            while (myStack.Count > 1)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[i] + "\t");

                }
                Console.WriteLine();
                //second loop is to ask for input again and again until the right value is input by the user
                while (true)
                {
                    Console.Write("Guess the first Number: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    //ends the loop, pops the item and assigns new value to the array when the first item is found
                    if (myStack.Peek() == input)
                    {
                        Console.WriteLine("You got that correct!");
                        Console.WriteLine("==========================");
                        myStack.Pop();
                        myArray = new int[myStack.Count];
                        myStack.CopyTo(myArray, 0);
                        Array.Sort(myArray);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try Again!");
                    }
                    stepsTaken++;
                }
            }
            score = 1000 - (stepsTaken - 4) * 100;
            Console.WriteLine("You guessed all the correct numbers in " + stepsTaken + " attempt");
            Console.WriteLine("Your score is: " + score);
        }
    }
}