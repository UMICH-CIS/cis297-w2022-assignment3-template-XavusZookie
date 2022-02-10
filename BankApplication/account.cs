using System;


/// <summary>
/// Xavier Begerow
/// cis 297 winter 2022
/// base account that has and can affect a balance
/// </summary>

public class account
{
    private decimal Balance;

    /// <summary>
    /// the balance property to allow access to get the provate Balance amount
    /// </summary>
    public decimal balance
    {
        get { return Balance; }
        
        
    }


    /// <summary>
    /// this is the constructor that takes a number and makes it the amount of money in the account
    /// </summary>
    /// <param name="balance">the amount in the account as money</param>
        public account(decimal balance)
        {
            if (balance >= 0m)
            {
                Balance = balance;
            }
            else
            {
                //throw Exception;
            }
        }

    /// <summary>
    /// this function will check if the account has enough money to withdraw the amount you want and if you do it takes that money out of the account, otherwise it tells you no
    /// </summary>
    /// <param name="withdraw">ammount to take out</param>
        public void debit(decimal withdraw)//withdraw
        {
            if (Balance >= withdraw)
            {
                Balance = Balance - withdraw;
               
            }
            else
            {
                Console.WriteLine("debit amount exceeded account balance amount" + "\n");
                
            }
        }

    /// <summary>
    /// this function adds the amount you want to deposit to the account balance
    /// </summary>
    /// <param name="deposit">amount you want to add</param>
        public void credit(decimal deposit)//add
        {
            Balance = Balance + deposit;
        }
    }

namespace BankApplication
{
    public class Account
    {
    }
}