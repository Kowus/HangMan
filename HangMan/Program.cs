using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escapeFromWhileLoop = true; // Easier to use this to exit a while loop when you know  what you're doing
            Hangman David = new Hangman("DAVID", "Brother's Name");
            Hangman Marissa = new Hangman("MARISSA", "Empoder!");
            Hangman Chelsey = new Hangman("CHELSEY", "iAmElite");
            Hangman Jerome = new Hangman("JEROME", "The late Mr. Jackson");
            Hangman Coke = new Hangman("COCA COLA", "Brrrrrrr! Kiss Ohemaa");
            Hangman Isaac = new Hangman("ISAAC", "Father's first name");
            Hangman Lydia = new Hangman("LYDIA", "MWME");
            Hangman Sam = new Hangman("BHATTACHARYYA", "Sam's last name");
            Hangman Esther = new Hangman("ESTHER", "Mother's first name");
            // Just created objects from class Hangman that I created myself with properties (string name, string hint)

            try // To catch all Errors
            {

                // Name list and hint list arranged according to index if David.Name has an index of 0,
                // David.Hint must also have the same index so that displayig the hint will be Easier

                string[] nameList = { David.Name, Marissa.Name, Chelsey.Name, Jerome.Name, Coke.Name, Isaac.Name, Lydia.Name, Sam.Name, Esther.Name };
                string[] hintList = { David.Hint, Marissa.Hint, Chelsey.Hint, Jerome.Hint, Coke.Hint, Isaac.Hint, Lydia.Hint, Sam.Hint, Esther.Hint };





                Random randomElementPicker = new Random(); // New variable of class System.Random()

                var randomIndex = randomElementPicker.Next(0, nameList.Length - 1); 
                /* Just to make sure the range is correct, I could go ahead and 
                 * change the max value to a number instead of an expression,
                 * but since the size of the array can change at any time,
                 * nameList.Length - 1 will do just fine. 
                 * 
                 * Oh, and btw, I subtracted 1 from it  because if there are 10 elements in an array,
                 * the length is 10 but to reference the 10th element, you must use [9]
                 */


                string systemWordChoice = nameList[randomIndex];
                // Console chooses a random word from the nameList array

                char[] hideTheWord = new char[systemWordChoice.Length];
                //Introduce a new variable to chop the strings down into individual characters



                Console.Write("Guess The Word \n\n                      Hint: {0}\n\n", hintList[randomIndex]);
                // Generate Hint. I must say, If you don't know me, 
                // Most of these hints will be useless to you.
                // Feel free to tweak code


                for (int i = 0; i < systemWordChoice.Length; i++)
                {
                    hideTheWord[i] = '*';
                    // Change the characters into * to
                }

                while (escapeFromWhileLoop)
                {
                    char userInputCharacter = char.Parse(Console.ReadLine().ToUpper());
                    // Take User Input : ONE CHARACTER AT A TIME!!!


                    for (int x = 0; x < systemWordChoice.Length; x++)
                    {
                        if (userInputCharacter == systemWordChoice[x])
                            hideTheWord[x] = userInputCharacter;
                        // Simply displays all the correct guesses you made
                    }


                    Console.WriteLine(hideTheWord);
                    // Display your progress/Attempt so far
                    
                    if (new string(hideTheWord) == systemWordChoice)
                        escapeFromWhileLoop = false;
                        // Just as I said,
                        // There are other ways of doing it tho
                        // quite an easy way out

                }

                Console.Clear();
                // Clear Everthing from the screen,

                Console.WriteLine("\n\n\n\n                     {0}",systemWordChoice);
                //Display the word

                Console.WriteLine("\n\n\n\n                        You Guessed Right");
                //Congratulations


                Console.ReadLine();
            }
            catch (FormatException e)
            {
                //int[] evenOrOdd = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Random randomNumberPicker = new Random();
                var numberIndex = randomNumberPicker.Next(0, 10);


                // I could have simply written Console.WriteLine(e.message);
                // But I just wanted the computer to randomly generate a message out of two options.

                // So we can conclude by saying, this block is useless to the Code. 
                // Was just added for Aesthetics
                if ((numberIndex%2)==0)
                {
                    Console.WriteLine(e.Message);
                }
                else
                {
                    Console.WriteLine("Ouch, one character at a time please! This is too much for me to process  ;(");
                }
                Console.ReadLine();
            }
        }
    }










    class Hangman
    {
        public string Name { get; set; }
        public string Hint { get; set; }

        public Hangman(string name, string hint)
        {
            this.Name = name;
            this.Hint = hint;
        }
        // You get it right?
    }

}


// In the future, you can turn this into a real game.
// Add score, game over if unsuccesful after 5 attempts,
// etc.
// Have you run for a number of times. Scores presented after each round
// Better exceptions mode other than just printing a bunch of messages