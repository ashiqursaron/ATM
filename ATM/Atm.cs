using System;


namespace myAtm
{
    class Account
    {
        
        
        
        //private string accountName ="";
        //private double amount = 0;
        public string accountName { set; get; }
        public double amount { set; get; }

        public Account(string accountName,double amount)
        {
            this.accountName = accountName;
            this.amount = amount;
        }
        

        public void Withdrawal(int withdrawnAmount)
        {
            if(withdrawnAmount <= 0)
            {
                Console.WriteLine("Invalid Amount!");
            }
            else if(withdrawnAmount > amount)
            {
                Console.WriteLine("Not Sufficient Balance!");
            }
            else
            {
                amount = amount - withdrawnAmount;
            }
            
            
        }
        public void Deposit(double depositAmount)
        {
            if (depositAmount <= 0)
            {
                Console.WriteLine("Invalid Amount!");
            }
            else
            {
                amount = amount + depositAmount;
            }
            

        }
        public void Transfer(Account account,double amount)
        {
            if(this.amount-amount < 0)
            {
                Console.WriteLine("Not Sufficient Balance!");
            }
            
            else
            {
                this.amount = this.amount - amount;
                account.Deposit(amount);
            }
        }
        public override string ToString()
        {
            return "ACCOUNT NAME: " + accountName + "\n"
                + "ACCOUNT BALANCE: " + amount;
        }

    }
    class Atm
    {
        public static void Main(string[] args)
        {

            // Exercise 4-01

            Account heikkisAccount = new Account("Heikki's account", 100.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);
            Console.WriteLine("Intial state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);
            heikkisAccount.Withdrawal(20);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.amount);
            heikkisSwissAccount.Deposit(200);
            Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.amount);
            Console.WriteLine("End state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);
            heikkisAccount.Transfer(heikkisSwissAccount, 10);
            //Console.WriteLine(heikkisAccount);
            //Console.WriteLine(heikkisSwissAccount);


            // Exercise 4-02



            Account personal_account = new Account("Personal account", 0);
            heikkisAccount.Deposit(1000);
            heikkisAccount.Transfer(personal_account, 100);
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personal_account);
            



        }
    }
}