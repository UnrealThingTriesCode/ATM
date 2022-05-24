//Build using .NET 6.0.300
//Version_Control [.NET 6]
/* todo
[ ]Save new pincode when changing the pincode via the main menu
[x] Not require pincode when going to main menu
[x] Add logout option
[ ]add a catch block to prevent instant termination of the program
[ ]different WriteLine when entering characters instead of numbers
[ ]save edited balance to a general balance 'hub'
[ ]add a database of accounts and balances
 */
namespace atmrider
{
    public class Program
    {
        public static void Main(string[] args)
        {
bool i = false;
Console.WriteLine("What pincode do you want to use for this session?");
string mainpin = Console.ReadLine();
if (mainpin.Length <= 6 && mainpin.Length >= 4)
{
    i = true;
}
else
{
    Console.WriteLine("not");
    i = false;
    Environment.Exit(5);
}
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("| Welcome to Labree Banking, Please enter your pincode. | ");
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
string pin = Console.ReadLine();
Console.Write("Succes! We are logging you in.");

Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);

Console.Write(". | Succes!");

Thread.Sleep(200);

Console.WriteLine();
//creates a loop
while (i == true)
{
    do
    {
        //try catch block to prevent aborting the execution when invalid characters are entered
        
        if (pin == mainpin)
        {
            i = true;
            break;
        }
       else
        {
            i = false;
            Console.WriteLine("Wrong PIN code entered!");       
            Console.WriteLine("Try again? [y/n]");
            string key = Console.ReadLine();
            string letteryes = ("y");
            if (key == letteryes)
            {
                i = true;
                continue;
            }
            if (key == "n")
            {
                Environment.Exit(5);
            }
            else
            {
                Environment.Exit(5);
            }

        }



    } while (i == true);




    double bal = 10000;

    Console.WriteLine("Press 1. to see balance");

    Console.WriteLine("Press 2. to withdraw balance");

    Console.WriteLine("Press 3. to deposit");

    Console.WriteLine("Press 4. to change PIN");

    Console.WriteLine("Press 5. to log out");

    int ch = int.Parse(Console.ReadLine());
    
    switch (ch)
    {
        case 1:

            //see balance case

            Console.WriteLine("Your balance is " + bal);
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();
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
            //withdraw case
            Console.WriteLine("How much do you want to withdraw?");

            double withdrew = Double.Parse(Console.ReadLine());
            double newwithdrew = (bal - withdrew);
            bal = newwithdrew;

            Console.WriteLine("Succes, current balance: " + bal);
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();

            Console.WriteLine("Press 1. to exit.");

            Console.WriteLine("Press 2. to return to the main menu.");

            int c2 = int.Parse(Console.ReadLine());
            switch (c2)
            {
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    break;
            }
            break;
        case 3:
            //deposit case

            Console.WriteLine("How much do you want to deposit?");

            double dep = Convert.ToDouble(Console.ReadLine());
            double final = (dep + bal);

            Console.WriteLine("Please insert the money in the ATM");

            Thread.Sleep(2000);

            Console.Write("Processing");

            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Console.WriteLine();

            Console.WriteLine("Succes! Your total balance is " + final);

            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine();

            Console.WriteLine("Press 1. to exit.");

            Console.WriteLine("Press 2. to return to the main menu.");

            int c3 = int.Parse(Console.ReadLine());
            switch (c3)
            {
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    break;
            }
            break;
        case 4: //change pin case

            Console.WriteLine("Do you want to change your PIN? [Y] [N]");

            string userInput = Console.ReadLine();

            if (userInput == "Y" || userInput == "y")
            {
                Console.WriteLine("What do you want your new PIN to be? (4-6 digits)");

                string newpin = (Console.ReadLine());

                try
                {
                    //Check if the pin is within 4-6 digit range
                    while (newpin.Length > 6)
                    {
                        Console.WriteLine("Digit limit exceeded, please try again. ");

                        newpin = Console.ReadLine();
                    }
                    //Checks if the pin is within 4-6 digit range
                    while (newpin.Length < 4)
                    {
                        Console.WriteLine("Invalid pin code, please try again.");

                        newpin = Console.ReadLine();
                        mainpin = newpin;
                    }
                    Console.WriteLine("Succes! Your new pin is: " + newpin);

                    break;
                }
                //error handeling
                catch (Exception e)
                {
                    Console.WriteLine("Invalid user input, Please try again. Error: " + e.Message);
                    break;
                }
            }
            else
            {
                Console.WriteLine("Your PIN hasn't been changed, Redirecting you to the login page...");
                break;
            }
            case 5: //logout case
                Console.WriteLine("Do you really want to log out? [Y/n]");
                string logout = Console.ReadLine();
                if (logout == "y" || logout == "Y")
                {
                    Console.Write("Logging you out");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.WriteLine("Succes! Have a nice day.");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }

                if (logout == "n" || logout == "N")
                {
                    Console.Write("Redirecting you to the main menu");
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.Write(".");
                    Thread.Sleep(400);
                    Console.WriteLine();
                    
                }

                break;
    }
}
        }
    }
}
