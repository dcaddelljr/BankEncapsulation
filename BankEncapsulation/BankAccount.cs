using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}
		private double balance; //only accessible in this class
		public void Deposit(double depositAmount)
		{
			balance += depositAmount;
		}

		public void Withdraw(double depositAmount)
		{
			balance -= depositAmount;
		}
		public double GetBalance()
		{
			return balance;
		}
	}
}

