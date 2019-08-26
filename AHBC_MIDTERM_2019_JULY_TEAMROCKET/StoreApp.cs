using System;
using System.Collections.Generic;
using System.IO;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class StoreApp
    {
        //var menu = new Menu() { };
        bool isNotMenuChoice;
        IntegerValidator intergerValidator = new IntegerValidator { };
        bool isValid;
        int startMenuChoice = 0;
        string initalUserInput = "";
        




        public void Run()
        {

            Console.WriteLine("Welcome to '@void', your number one stop for the latest in digiatl fashion! \nSelecet below from the following options:\n");
            Console.WriteLine("[1] Shop \n[2] About \n[3] Exit");

            initalUserInput = Console.ReadLine();

            do
            {
                do
                {
                    if (IntegerValidator.Validate(initalUserInput))
                    {
                        startMenuChoice = int.Parse(initalUserInput);
                        isValid = true;
                    }
                    else
                    {
                        Console.Clear();
                        menuOptions();
                        initalUserInput = Console.ReadLine();

                        isValid = false;
                    }


                } while (!isValid);


                switch (startMenuChoice)
                {
                    case 1:

                        
                        break;

                    case 2:
                        /// WRITE OUR STORE BIO!!!!
                        Console.Clear();
                        Console.WriteLine("\n");

                        menuOptions();
                        initalUserInput = Console.ReadLine();
                        isNotMenuChoice = true;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Thank you and B#!");
                        isNotMenuChoice = false;
                        break;

                    default:
                        Console.Clear();
                        Console.Write("Not a valid option. ");
                        menuOptions();
                        initalUserInput = Console.ReadLine();
                        isNotMenuChoice = true;
                        break;
                }

            } while (isNotMenuChoice);


            Console.Read();


        }

        public void menuOptions()
        {

            Console.WriteLine("Please, selecet below from the following options:\n");
            Console.WriteLine("[1] Shop \n[2] About \n[3] Exit");

        }




    }
}