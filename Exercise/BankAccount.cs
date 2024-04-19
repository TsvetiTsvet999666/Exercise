using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class BankAccount
    {
        public string Id { get; private set; }
        public decimal Balance { get; private set; }
        public BankAccount(string id)
        {
            Id = id;
            Balance = 0;
        }
        public BankAccount(string id, decimal balance)
        {
            Id = id;
            Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive.");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account ID: {Id}, Balance: {Balance:F2}";
        }
    }   
}
