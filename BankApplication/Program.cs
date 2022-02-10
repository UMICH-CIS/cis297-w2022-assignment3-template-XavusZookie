using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Xavier Begerow
/// cis 297 winter 2022
/// main function to test the classes
/// </summary>
namespace BankApplication
{
    class Program
    {
        /// <summary>
        /// test the polymorphic banking array with user input
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            checkingsaccount one = new checkingsaccount(150, 2);
            checkingsaccount three = new checkingsaccount(200, 3);
            checkingsaccount four = new checkingsaccount(75, .5m);
            checkingsaccount six = new checkingsaccount(110, 1);
            savingsaccount two = new savingsaccount(1000, .03m);
            savingsaccount five = new savingsaccount(1234, .025m);
            savingsaccount seven = new savingsaccount(300, .01m);
            savingsaccount eight = new savingsaccount(10300, .05m);



            Type type;
            decimal userinput;

            account[] arr = { one, two, three, four, five, six, seven, eight };

            for (int i = 0; i < 8; i++)
            {
                type = arr[i].GetType();
                if (arr[i].Equals(typeof(savingsaccount)))
                {
                    Console.WriteLine("Savings account balance: " + arr[i].balance + "$\n" + "    account number: " + (i + 1));

                    Console.Write("Withdraw amount: ");

                    userinput = decimal.Parse(Console.ReadLine());

                    ((savingsaccount)arr[i]).debit(userinput);




                    Console.Write("Deposit amount: ");

                    userinput = decimal.Parse(Console.ReadLine());

                    ((savingsaccount)arr[i]).credit(userinput);

                    Console.WriteLine("Savings account balance: " + arr[i].balance + "$\n" + "    account number: " + (i + 1));

                    ((savingsaccount)arr[i]).debit(((savingsaccount)arr[i]).CalculateInterest());

                    Console.WriteLine("You have accrued interest! \nSavings account balance: " + arr[i].balance + "$\n" + "    account number: " + (i + 1));

                }
                else
                {
                    Console.WriteLine("Checking account balance: " + arr[i].balance + "$\n" + "    account number: " + (i + 1));

                    Console.Write("Withdraw amount: ");

                    userinput = decimal.Parse(Console.ReadLine());

                    ((checkingsaccount)arr[i]).debit(userinput);




                    Console.Write("Deposit amount: ");

                    userinput = decimal.Parse(Console.ReadLine());

                    ((checkingsaccount)arr[i]).credit(userinput);

                    Console.WriteLine("Savings account balance: " + arr[i].balance + "$\n" + "    account number: " + (i + 1));


                }



            }


        }
    }

    public class program
    {
    }
}
