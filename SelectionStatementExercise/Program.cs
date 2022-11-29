namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("Try to guess my favorite number, it is between 1 and 10.");
                var r = new Random();
                var favNumber = r.Next(1, 10);
                var userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Good guess, but that number is too low.");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Nice try, but that number is too high!");
                }
                else
                {
                    bool v = userInput == favNumber;
                    Console.WriteLine("Congratulations are in order, for you have guessed correctly!!");
                    break;
                }
            } 
            while (true);        
        }
    }

}
