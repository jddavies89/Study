// ===============================
// AUTHOR        :   Joe Richards
// CREATE DATE   :   11/07/2017
// PURPOSE       :   Learn Ohms Law
// VERSION       :   1.0
// ===============================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricians_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops the program.
            Start:
            //Declaires the variables.
            int Sentence = 0;
            int Ampere = 0;
            int Voltage = 0;
            int Ohms = 0;
            //Produces a random number.
            Random rnd = new Random();
            //Assigns the random numbers.
            Sentence = rnd.Next(1, 3);
            Ampere = rnd.Next(1, 13);
            Voltage = rnd.Next(1, 250);
            Ohms = rnd.Next(1, 19);
            
            //Three mathmatical sentences that is used for Ohms Law.
            string Sentence1 = "If I is " + Ampere + " and R is " + Ohms + " What is V?";
            string Sentence2 = "If V is " + Voltage + " and I is " + Ampere + " What is R?";
            string Sentence3 = "If V is " + Voltage + " and R is " + Ohms + " What is I?";
            
            //Stores the results for the actual answer and the human answer.
            int HumanAnswer = 0;
            int AppAnswer = 0;

            //Display one of the three sentences.
            if (Sentence == 1)
            {
                //Displays Sentence one to the screen.
                Console.WriteLine(Sentence1);
                //Calculates the equation.
                AppAnswer = Ampere * Ohms;
            }
            else if (Sentence == 2)
            {
                //Displays Sentence one to the screen.
                Console.WriteLine(Sentence2);
                //Calculates the equation.
                AppAnswer = Voltage / Ampere;
            }
            else if (Sentence == 3)
            {
                //Displays Sentence one to the screen.
                Console.WriteLine(Sentence1);
                //Calculates the equation.
                AppAnswer = Voltage / Ohms;
            }

            //User writes the answer in.            
            Console.WriteLine("What is the Answer?");
            HumanAnswer = Convert.ToInt32(Console.ReadLine());
           
            //For checking the answer.
            check:
            if (AppAnswer == HumanAnswer)
            {
                //Clear Screen.
                Console.Clear();
                //Displays the 
                Console.WriteLine("Correct!!!!");
            }
            else if (AppAnswer != HumanAnswer)
            {
                //Displays the help.
                Console.WriteLine("Please try again.");
                Console.WriteLine("");
                Console.WriteLine("V, Voltage, Volts");
                Console.WriteLine("R, Ohms, Resistance.");
                Console.WriteLine("I, Current, Ampere.");
                Console.WriteLine();
                Console.WriteLine("      V     ");
                Console.WriteLine("   I     R  ");
                Console.WriteLine();
                Console.WriteLine("V = I * R");
                Console.WriteLine("R = V / I");
                Console.WriteLine("I = V / R");
                Console.WriteLine();                
                //User writes the answer in.
                Console.WriteLine("Do you have an idea now?");
                HumanAnswer = Convert.ToInt32(Console.ReadLine());
                //Checks the answer.
                goto check;
            }
            //Loops the program.
            goto Start;    
        }    
    }    
}