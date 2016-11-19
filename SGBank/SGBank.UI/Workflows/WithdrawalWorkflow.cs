using SGBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.UI.Workflows
{
    public class WithdrawalWorkflow
    {
        public void Execute(Account account)
        {
            decimal amount = GetAmountFromUser();
        }

        private decimal GetAmountFromUser()
        {
            decimal amount;
            bool isValid = false;
            do
            {
                Console.Clear();
                Console.Write("Enter amount to withdraw:");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out amount))
                {
                    if (amount <= 0)
                    {
                        Console.WriteLine("Please enter a positive number.");
                        Console.ReadLine();

                    }
                    else
                    {
                        isValid = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount.  Please enter a valid amount.");
                    Console.ReadLine();
                }
            } while (!isValid);

            return amount;
        }

        private void ProcessWithdrawal()
        {
            var ops = new AccountOperations();
            var response = ops.MakeWithdrawal(Account, amount);

            if (!response.Success)
            {
                Console.WriteLine("Error occurred.");
                Console.WriteLine(response.Message);

            }
        }
    }
}
