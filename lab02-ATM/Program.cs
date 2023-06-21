using System;
using System.Reflection.Metadata;

public class Program
{
    public static decimal Balance;
    public static void Main(string[] args)
    {
        ActivateInterface();
    }

    //////////////////////////////////////
    
    public static void ActivateInterface()
    {
        // Console.WriteLine(ViewBalance());
        Console.WriteLine("Welcome to our ATM interface");
        Console.WriteLine("you can enter '1' to view your balance\n  '2 to withdraw'\n  '3' to deposit \n and '4' to quit");
        string userChoice = Console.ReadLine();

        if(userChoice == "1")
        {
            Console.WriteLine("balance: ");
            Console.WriteLine(ViewBalance());
            ActivateInterface();

        }
        else if(userChoice == "2")
        {
            Console.WriteLine("please enter the amount...");
            string amountInput = Console.ReadLine();
            int amount2 = Convert.ToInt32(amountInput);
            WithDraw(amount2);
            Console.WriteLine("your new balance: " + ViewBalance());
            Console.WriteLine("");
            ActivateInterface();
        }
        else if (userChoice == "3")
        {
            Console.WriteLine("please enter the amount...");
            string amountInput = Console.ReadLine();
            int amount3 = Convert.ToInt32(amountInput);
            Deposit(amount3);
            Console.WriteLine("your new balance: " + ViewBalance());
            Console.WriteLine("");
            ActivateInterface();
        }
        else if (userChoice == "4"){
            Environment.Exit(0);
        }
    }
    public static decimal ViewBalance()
    {
        //decimal value = 0;
        // Console.WriteLine("your balance is: " + value);
            return Balance;
    }

    public static decimal WithDraw(decimal amount)
    {
        if(amount > Balance)
        {
            //throw new Exception("cannot withdraw ... check your balance");
            Console.WriteLine("cannot withdraw ... check your balance");
            return Balance;

        }
        else if (amount <= 0)
        {
            //throw new Exception("please enter a positive number...");
            Console.WriteLine("please enter a positive number...");
            return Balance;
        }
        else
        {
            Balance -= amount;
            return Balance - amount;
        }

    }
    
    public static decimal Deposit(decimal amount)
    {
        if(amount < 0)
        {
            throw new Exception("please enter a positive number...");
        }
        else
        {
            Balance += amount;
            return Balance + amount;
        }
    }


}