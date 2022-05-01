using System;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;

//creates a loop
int i = 0;
while (i < 5)
{
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine("| Welcome to Labree Banking, Please enter your pincode. | ");
    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
//try catch block to prevent aborting the execution when invalid characters are entered
    try
    {
        string pin = (Console.ReadLine());
//Check if the pin is within 4-6 digit range
        while (pin.Length > 6)
        {
            Console.WriteLine("Digit limit exceeded, please try again. ");
            pin = Console.ReadLine();
        }
//Checks if the pin is within 4-6 digit range
        while (pin.Length < 4)
        {
            Console.WriteLine("Invalid pin code, please try again.");
            pin = Console.ReadLine();
        }
    }
//error handeling
    catch (Exception e)
    {
        Console.WriteLine("Invalid user input, Please try again. Error: " + e.Message);
   }

    Console.Write("Succes! We are logging you in.");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write(".");
    Thread.Sleep(500);
    Console.Write(". | Succes!");
    Thread.Sleep(200);
    Console.WriteLine();

    double bal = 10000;

    Console.WriteLine("Press 1. to see balance");
    Console.WriteLine("Press 2. to withdraw balance");
    Console.WriteLine("Press 3. to deposit");
    Console.WriteLine("Press 4. to change PIN");
    int ch = int.Parse(Console.ReadLine());
    switch (ch)
    {
        case 1:
            Console.WriteLine("Your balance is " + bal);
            Console.WriteLine("Press 1. to exit.");
            Console.WriteLine("Press 2. to return to the main menu.");
            int c1 = int.Parse(Console.ReadLine());
            switch (c1)
            {
                case 1:
                    Environment.Exit(0);
                    break;

                case 2:

                break;
                    
            }
            break;

        case 2:
            Console.WriteLine("How much do you want to withdraw?");
            double withdrew = Double.Parse(Console.ReadLine());
            double newwithdrew = (bal - withdrew);
            bal = newwithdrew;
            Console.WriteLine("Succes, current balance: " + bal);
            break;
    }

}
