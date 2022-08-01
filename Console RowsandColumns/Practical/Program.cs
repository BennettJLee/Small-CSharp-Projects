using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChars = 5;
            string c = "*";
            try
            { 
                Console.WriteLine("Enter the character you'd like to use");
            
                c = Console.ReadLine();

                Console.WriteLine("Enter the number of characters");

                numChars = int.Parse(Console.ReadLine());


                Console.WriteLine();
                DrawChars(numChars, c);


                // Wait for user to have read the output
                Console.WriteLine();
                Console.Write("<Press enter to finish>");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Sorry but an error has occurred, please enter data appropriately");
                Console.ReadLine();
            }
            
        }

        /// <summary>
        /// Draws a line of characters
        /// </summary>
        /// <param name="n">Number of characters to draw</param>
        /// <param name="s">Character to draw n times</param>
        static void DrawChars(int n, string s)
        {
            for (int r = 1;  r < n+1; r++)
            {
                for (int c = 1; c < n+1; c++)
                {
                    if(c == r)
                    {

                        Console.Write(r % 10);
                    }
                    else
                    {
                        Console.Write(s);
                    }
                    
                }
               Console.WriteLine();
            }
            
        }
    }
}
