using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate = 0f;
        
        switch (balance)
        {
			case < 0:
				interestRate = 3.213f;
				break;
			case < 1000:
				interestRate = 0.5f;
				break;
			case < 5000:
				interestRate = 1.621f;
				break;
			case >= 5000:
				interestRate = 2.475f;
				break;
		}

        return interestRate;
    }

    public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int yearsBeforeDesiredBalance = 0;

		while (balance < targetBalance)
		{
            balance = AnnualBalanceUpdate(balance);
            yearsBeforeDesiredBalance++;
        }

        return yearsBeforeDesiredBalance;
    } 
}
