using SGBank.Data;
using SGBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.BLL
{
    public class AccountOperations
    {
        public bool MakeWithdrawal(Account account, decimal amountToWithdraw)
        {
            var isSuccessful = false;

            var repo = AccountFactory.CreateAccountRepository();

            var source = repo.GetAccountByNumber(account.AccountNumber);
            if (source != null)
            {
                if (source.Balance >= amountToWithdraw)
                {
                    isSuccessful = repo.Withdrawal(source, amountToWithdraw);

                    if (isSuccessful)
                    {
                        response.Success = true;
                        response.AccountInfo = source;
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = "Withdraw failed";
                    }
                }
                else
                {
                    response.Success = false;
                    response.Message = "Not";
                }
                }
            }

            return isSuccessful;
        }

        public AccountResponse GetAccount(string accountNumber)
        {
            AccountResponse response = new AccountResponse();

            var repo = AccountFactory.CreateAccountRepository();
            var account = repo.GetAccountByNumber(accountNumber);

            if (account != null)
            {
                response.Success = true;
                response.AccountInfo = account;
            }
            else
            {
                response.Success = false;
                response.Message = $"No account found for account number: {accountNumber}";
            }
            return account;
        }
    }
}
