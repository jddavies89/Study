
// ================================================
// AUTHOR        :   Joe Richards
// CREATE DATE   :   11/07/2017
// UPDATE        :   02/02/2018
// PURPOSE       :   Learn Ohms Law
// VERSION       :   2.0
// ------------------------------------------------
// Added in calulations to workout Watts as well.
// ------------------------------------------------
// ================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricians_Law_v2
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
            int Watts = 0;

            //Produces a random number.
            Random rnd = new Random();
            //Assigns the random numbers.
            Sentence = rnd.Next(1, 6);
            Ampere = rnd.Next(1, 32);
            Voltage = rnd.Next(1, 250);
            Ohms = rnd.Next(1, 19);
            Watts = rnd.Next(1, 400);


            //Six mathmatical sentences that is used for Ohms Law.
            string Sentence1 = "If I is " + Ampere + " and R is " + Ohms + " What is V?";
            string Sentence2 = "If V is " + Voltage + " and I is " + Ampere + " What is R?";
            string Sentence3 = "If V is " + Voltage + " and R is " + Ohms + " What is I?";
            string Sentence4 = "If W is " + Watts + " and I is " + Ampere + " What is V?";
            string Sentence5 = "If I is " + Ampere + " and V is " + Voltage + " What is W?";
            string Sentence6 = "If V is " + Voltage + " and W is " + Watts + " What is I?";


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
                //Displays Sentence two to the screen.
                Console.WriteLine(Sentence2);
                //Calculates the equation.
                AppAnswer = Voltage / Ampere;
            }
            else if (Sentence == 3)
            {
                //Displays Sentence three to the screen.
                Console.WriteLine(Sentence1);
                //Calculates the equation.
                AppAnswer = Voltage / Ohms;
            }
            else if (Sentence == 4)
            {
                //Displays Sentence four to the screen.
                Console.WriteLine(Sentence4);
                //Calculates the equation.
                AppAnswer = Watts / Ampere;
            }
            else if (Sentence == 5)
            {
                //Displays Sentence five to the screen.
                Console.WriteLine(Sentence5);
                //Calculates the equation.
                AppAnswer = Ampere * Voltage;
            }
            else if (Sentence == 6)
            {
                //Displays Sentence six to the screen.
                Console.WriteLine(Sentence6);
                //Calculates the equation.
                AppAnswer = Voltage * Watts;
            }
            
            //User writes the answer in. 
            //try catch to make sure the user types a numeric value.
            Console.WriteLine("What is the Answer?");
            try
            {
                HumanAnswer = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Didn't understand your answer.");
                goto check;
            }
           

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
                Console.WriteLine("------------");
                Console.WriteLine("      W     ");
                Console.WriteLine("   I     v  ");
                Console.WriteLine();
                Console.WriteLine("V = I * R");
                Console.WriteLine("R = V / I");
                Console.WriteLine("I = V / R");
                Console.WriteLine("---------");
                Console.WriteLine("W = I * V");
                Console.WriteLine("I = W / V");
                Console.WriteLine("V = W / I");
                Console.WriteLine();
                //User writes the answer in.
                Console.WriteLine("Do you have an idea now?");
                try
                {
                    HumanAnswer = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Didn't understand your answer.");
                    goto check;
                }
                //Checks the answer.
                goto check;
            }
            //Loops the program.
            goto Start;
        }
    }
}