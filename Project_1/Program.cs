using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_1
{
   public class Program
    {
        static void Main(string []args)
        {
            Random r  = new Random();
            int winNum = r.Next(0,100);
            bool win = false;

            do{
                Console.WriteLine("Guess a number between 0 and 100");
                string input = Console.ReadLine();

                int guessedNumber = int.Parse(input);

                if(guessedNumber > winNum)
                {
                    Console.WriteLine("Too High...... Think Lower");
                }
               else if(guessedNumber < winNum)
                {
                    Console.WriteLine("Too Low...... Think Higher");
                }
                else if(guessedNumber == winNum)
                {
                 Console.WriteLine("BooYahh!!...... you got it");
                 win  = true;   
                }
                Console.WriteLine();

            }
            while(win == false);
        }
    }
}