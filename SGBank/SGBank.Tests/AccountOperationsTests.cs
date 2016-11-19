using NUnit.Framework;
using SGBank.BLL;
using SGBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Tests
{
    [TestFixture]
    class AccountOperationsTests
    {
        [Test]
        public void MakeWithdrawal()
        {
            AccountOperations ops = new AccountOperations();
            Account account = new Account() { AccountNumber = "123456", Balance = 1234.56m };
            Assert.IsTrue(ops.MakeWithdrawal(account, 2000));
        }
    }
}
