using System;

/// <summary>
/// Xavier Begerow
/// cis 297 winter 2022
/// savings account is derived from base account and adds the interest rate and calculate interest function to find how much the savings balance grows by
/// </summary>
public class savingsaccount : account
{
	private decimal Interest;

	/// <summary>
	/// initializes the savings account interest rate and passes the balance to the base constructor
	/// </summary>
	/// <param name="balance"> what the account will have in money</param>
	/// <param name="interest">how much the account will gain is determined by the interest rate</param>
	public savingsaccount(decimal balance, decimal interest) : base(balance)
	{ 
			Interest = interest;
		
	}

	/// <summary>
	/// calculates the account balance times the interest rate to see how much you gain
	/// </summary>
	/// <returns>returns the ammount to add for interest</returns>
	public decimal CalculateInterest()
	{
		return Interest * balance;
	}
}

namespace BankApplication
{
	public class Savingsaccount : Account
	{
	}
}