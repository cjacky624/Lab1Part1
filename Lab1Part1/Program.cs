using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int numberOne; //First number
            int numberTwo;//Second number
            string userInput;

            Console.WriteLine("Enter a three digit number"); //message that shows to the user
            userInput = Console.ReadLine(); //Stores user input
            numberOne = int.Parse(userInput); //Converts user input into int

            Console.WriteLine("Enter a three digit number");
            userInput = Console.ReadLine();
            numberTwo = int.Parse(userInput);

            Console.WriteLine(CheckIfNumbersEqual(numberOne, numberTwo));
        }


        public static bool CheckIfNumbersEqual(int numberOne, int numberTwo) //Method that returns a boolean(true or false)
        {
            //Declaring variables
            int numberOneOnes;
            int numberOneTens;
            int numberOneHundreds;
            int numberTwoOnes;
            int numberTwoTens;
            int numberTwoHundreds;
            int hundredsTotal;
            int tensTotal;
            int onesTotal;

            numberOneHundreds = numberOne / 100; //Divide by 100 to get first digit
            numberOneTens = (numberOne / 10) % 10; //Divide by 10, then % to get second digit
            numberOneOnes = (numberOne % 100) % 10; 

            numberTwoHundreds = numberTwo / 100;
            numberTwoTens = (numberTwo / 10) % 10;
            numberTwoOnes = (numberTwo % 100) % 10;

            hundredsTotal = numberOneHundreds + numberTwoHundreds;
            tensTotal = numberOneTens + numberTwoTens;
            onesTotal = numberOneOnes + numberTwoOnes;

            if(hundredsTotal == tensTotal && tensTotal == onesTotal)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
    }
}
