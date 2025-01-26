using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal abstract class BankAccountState
    {
        public decimal Balance { get; set; }

        public BankAccount Account { get; set; }

        public abstract void Deposit (decimal amount);
        public abstract void Withdraw (decimal amount);
    }

    internal class PositiveBankAccountState : BankAccountState
    {
        public PositiveBankAccountState(decimal initialAmount, BankAccount account)
        {
            Balance = initialAmount;
            Account = account;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine("Dépot de " + amount);
            Balance += amount;
            Console.WriteLine($"Balance du compte : {Balance}");
            if(Balance > 1000) 
            {
                Account._state = new VIPBankAccountState(Balance, Account);
            }
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
            if (Balance < 0) {
                Console.WriteLine("Le solde passe en négatif : "+ Balance);
                Account._state = new NegativeBankAccountState(Balance, Account); }
        }
    }

    internal class NegativeBankAccountState : BankAccountState
    {
        public NegativeBankAccountState( decimal amount, BankAccount account)
        {
            Account = account;
            Balance = amount;
            
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine("Dépot sur compte négatif : + "+ amount);
            Balance += amount;
            if(Balance > 0)
            {
                Console.WriteLine("Votre compte redevient positif");
                Account._state = new PositiveBankAccountState(Balance, Account);
              
            }
            Console.WriteLine($"Solde : {Balance}");
        }

        public override void Withdraw(decimal amount)
        {
            throw new CannotWithdrawNegativeBankAccountBalance();
        }
    }

    internal class VIPBankAccountState : BankAccountState
    {
        public VIPBankAccountState(decimal amount, BankAccount account)
        {
            Account = account;
            Balance = amount;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"Dépot sur un compte VIP :{amount} . Prime de 10%");
          Balance += amount * 1.1m;
            Console.WriteLine("Nouveau solde : " + Balance);
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
            if(Balance < 1000)
            {
                Account._state = new PositiveBankAccountState(Balance, Account);
            }
        }
    }

    public class CannotWithdrawNegativeBankAccountBalance : Exception { }



    public class BankAccount

    {

        internal BankAccountState _state;
       public decimal Balance => _state.Balance;

       
        public BankAccount(decimal amount) 
        { 
           _state = new PositiveBankAccountState(amount, this);
            Console.WriteLine($"Balance du compte : {Balance}");
        }

        public void Withdraw(decimal amount) 
        {
            _state.Withdraw(amount);
            
        }

        public void Deposit (decimal amount)
        {

            _state.Deposit(amount);
      
        }
    }
}
