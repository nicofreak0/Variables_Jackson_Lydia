namespace Variables_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declares an integer to favorite number
            int favoriteNumber;
            // booleans initialized false for jumping and running
            bool isJumping = false, isRunning = false;

            // declared random float variable
            float myFloat;
            // assigning the favoriteNumber to 6
            favoriteNumber = 6;
            // assigning myFloat to 66.66
            myFloat = 66.66f;
            // initalizing constant finalGrade to 98
            const double finalGrade = 98.0;


            // prints all variables to console
            Console.WriteLine("Favorite Number: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating Number: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);

        }
    }
}