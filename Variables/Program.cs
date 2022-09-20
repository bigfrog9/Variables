using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is John's project for Variables, I'll be uploading this on Github.");
            //This is a comment, it (hopefully) has no effect on code
            
            int score=0; //This is declaring (defining) "score" is an integer
            //int means any whole number, negative or positive. It does not include fractions or decimals

            Console.WriteLine("Score: " + score); //This is to display the score, the text in quotation marks isn't needed, just helpful to the player

            int enemypoints;

            enemypoints = 5;

            score = score + enemypoints;

            Console.WriteLine("Win Count: " + score);

            score = 1000; //"score" and "lapTime" are basically just x and y, just variables that can be defined as anything

            Console.WriteLine(score);

            //floating points

            float lapTime; //declaration

            lapTime = 0.0f; //initialization
            
            Console.WriteLine(lapTime);
            
            lapTime = 65.357f;
            
            Console.WriteLine(lapTime);

            //string (text)
            string title; //declaration
            title = "John Wohler";
            Console.WriteLine(title);
            
            Console.ReadKey(true); //wait for keypress
        }
    }
}
