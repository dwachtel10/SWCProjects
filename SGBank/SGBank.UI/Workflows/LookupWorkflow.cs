using SGBank.BLL;
using SGBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.UI.Workflows
{
    class LookupWorkflow
    {
        public void Execute()
        {
            string accountNumber = GetAccountNumberFromUser();
            var account = RetrieveAccountByNumber(accountNumber);
            DisplayAccount(account);
        }
        private string GetAccountNumberFromUser()
        {
            string accountNumber = "";

            Console.Clear();
            Console.Write("Enter an Account Number:");
            accountNumber = Console.ReadLine();

            return accountNumber;
        }

        private Account RetrieveAccountByNumber(string accountNumber)
        {
            var ops = new AccountOperations();
            var response = ops.GetAccount(accountNumber);
            if (response.Success)
            {
                return response.AccountInfo;
            }
            //Account account;
            else
            {
                Console.WriteLine("Error Occurred.");
                Console.WriteLine(response.Message);
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }

            return null;
        }

        private void DisplayAccount(Account account)
        {
            DisplayAccountInformation(account);
            DisplayAccountMenu(account);
        }

        private void DisplayAccountInformation(Account account)
        {
            Console.Clear();
            Console.WriteLine("Account Information");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Name: {account.Name}");
            Console.WriteLine($"Person: {account.FirstName} {account.LastName}");
            Console.WriteLine($"Balance: {account.Balance:C}");
            Console.WriteLine();
        }

        private void DisplayAccountMenu(Account account)
        {
            string input = "";
            do
            {
                DisplayAccountInformation Account;

                
                Console.WriteLine("1. Withdrawal");
                Console.WriteLine("2. Deposit");
                Console.WriteLine($"3. Deposit");
                Console.WriteLine($"4. Transfer");
                Console.WriteLine($"5. Close Account");
                Console.WriteLine();
                Console.WriteLine("Press (Q) to quit.");
                Console.WriteLine();


            }
        }

        private void ProcessChoice(string choice, Account account)
        {
            switch (choice)
            {
                case "1":
                    WithdrawalWorkflow withdrawWF = new WithdrawalWorkflow();
                    withdrawWF.Execute(account);
                    break;
            }
        }
    }
}
