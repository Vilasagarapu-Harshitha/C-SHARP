using System;

abstract class WithdrawalAmount
{
    public abstract void Withdraw(int amount);
}

class FixedAmount
{
    public int balance;

    public FixedAmount()
    {
        balance = 10000;
    }
}

class Bank : WithdrawalAmount
{
    private FixedAmount fixedAmount;

    public Bank(FixedAmount fixedAmount)
    {
        this.fixedAmount = fixedAmount;
    }

    public override void Withdraw(int amount)
    {
        if (fixedAmount.balance - amount < 10000)
        {
            Console.WriteLine("Maintain minimum balance 10000");
        }
        else if (amount > fixedAmount.balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            fixedAmount.balance -= amount;
            Console.WriteLine("The available balance:"+ fixedAmount.balance);
        }
    }

    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Please provide a withdrawal amount as a command line argument.");
            return;
        }

        int amount;
        if (!int.TryParse(args[0], out amount))
        {
            Console.WriteLine("Please provide a valid integer as the withdrawal amount.");
            return;
        }

        FixedAmount fixedAmount = new FixedAmount();
        Bank bank = new Bank(fixedAmount);

        bank.Withdraw(amount);
    }
}