using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Bank
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private int amount;
        private int accountbalance;

        public Bank(int accountNo, string customerName, string accountType, char transactionType, int amount, int accountbalance)
        // Default Constructor
        {
            //Console.WriteLine("Enter Customer Name, Account No, Account Type, Transaction Type(D/W), Amount, Balance ");
            this.customerName = customerName;
            this.accountNo = accountNo;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.accountbalance = accountbalance;
        }
        public void Credit(int amount)
        {
            accountbalance = accountbalance + amount;
        }
        public void Debit(int amount)
        {
            accountbalance = accountbalance - amount;
        }
        public void Update()
        {
            if (transactionType == 'D' || transactionType == 'd')
                Credit(amount);
            else if (transactionType == 'w' || transactionType == 'W')
                Debit(amount);
        }
        public void ShowData()
        {
            Console.WriteLine($"Custtomer Name :{customerName}");
            Console.WriteLine($"Account Number: {accountNo}");
            Console.WriteLine($"Account Type :{accountType}");
            Console.WriteLine($"Transaction Type  :{transactionType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance :{accountbalance}");
        }

    }
}

