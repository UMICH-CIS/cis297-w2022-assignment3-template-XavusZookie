



using System;

/// <summary>
/// Xavier Begerow
/// cis 297 winter 2022
/// checking account derives from account and adds the fee to each transaction
/// </summary>
public class checkingsaccount : account
{
	private decimal Fee;

	/// <summary>
	/// constructs the checking account with a fee and then passes balance to the base constructor
	/// </summary>
	/// <param name="balance">how much money the account will have</param>
	/// <param name="fee">how much will be subtracted for each transaction</param>
	public checkingsaccount(decimal balance, decimal fee) : base(balance)
	{
		Fee = fee;
	}

	/// <summary>
	/// is the new version of debit that adds the fee to the withdraw amount and then calls the base debit
	/// </summary>
	/// <param name="withdraw">the amount to take out</param>
	new public void debit(decimal withdraw)//withdraw
	{
		base.debit(withdraw + Fee);
	

	}

	/// <summary>
	/// a new credit function that takes away the fee from the amount to add to the function then uses the base function to add that
	/// </summary>
	/// <param name="deposit">the amount ot add to the account</param>
	new public void credit(decimal deposit)//add
	{

		base.credit(deposit - Fee);
		

	}
}

namespace BankApplication
{
	public class Checkingsaccount : Account
	{
	}
}