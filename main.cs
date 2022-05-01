using System;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;

int i = 0;
while (i <5)
    {
    Console.WriteLine("Welcome to Labree Banking, Please enter your pincode. ");
try
{
    string pin = (Console.ReadLine());
    //Check if the pin is within 4-6 digit range
    while (pin.Length > 6)
    {
        Console.WriteLine("Digit limit exceeded, please try again. ");
        pin = Console.ReadLine();
    }
    //Check if the pin is within 4-6 digit range
    while (pin.Length < 3)
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
Console.Write(". | ");
Thread.Sleep(200);
}
