using System;

namespace Variables_Dallas
{
    class Program
    {
        static void Main(string[] args)
        {
            // declars variables
            int favoriteNumber;
            bool isJumping = false, isRunning = false;
            float myFloat;
            favoriteNumber = 6;
            myFloat = 54.65f;
            const double finalGrade = 90.0;
            // displays variables
            Console.WriteLine("favorite #: " + favoriteNumber);
            Console.WriteLine("jumping: " + isJumping);
            Console.WriteLine("running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade #: " + finalGrade);

        }
    }
}
