using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadacha01;

namespace BankAccountTests
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void AccountInitializeWithPositiveValue()
        {
            BankAccount acount = new BankAccount(2000m);
            Assert.AreEqual(2000m, acount.Balance);
        }

        [Test]
        public void DepositShouldAddMoney()
        {
            //Arrange
            BankAccount account = new BankAccount();

            //Act
            account.Deposit(50);

            //Assert
            Assert.IsTrue(account.Balance == 50);
        }

    }
}
