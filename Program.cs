namespace Another_if_else_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The program asks user a question and user should answer 'yes' or 'no'
            Console.WriteLine("Are you a cat? Enter yes or no:");
            string answer = Console.ReadLine();

            //Bool without true or false
            bool isCat;


            /*Checks if answer contains spesific strings, turns the bool true or false based on the answer and calls methods.
            We could write all in this if else statement and define more bools, but this shows that it is possible to modify the
            bool with other values and make the code then execute other things.
            */
            
            if (answer.Contains("yes"))
            {
                isCat = true;
                PrintMessage1();
            }
            else if (answer.Contains("no"))
            {
                isCat = false;
                PrintMessage2();
            }
            else
            {
                Console.WriteLine("You did not answer the question.");
            }

        }
        static void PrintMessage1()
        {
            Console.WriteLine("You are a cat.");

        }

        static void PrintMessage2()
        {
            Console.WriteLine("You are not a cat.");
        }
    }
}
