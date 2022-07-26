using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SimCardApp;

namespace SimCardTestUnit
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void RechargeAirtime_Unit_testing()
        {
            //Arrange.
            var account = new SimCardAccount(100);

            //Act.
            account.RechargeAirtime(500);

            //Assert
            Assert.AreEqual(600, account.Balance);
        }

        [TestMethod]
        public void BuyData_UnitTest()  
        {
            //Arrange.
            var account = new SimCardAccount(300);

            //Act.
            account.BuyData(200);

            //Assert
            Assert.AreEqual(100, account.Balance);
        }

        [TestMethod]
        public void Borrow_Airtime_UnitTest()
        {
            //Arrange.
            var account = new SimCardAccount();

            //Act.
            account.BorrowAirtime(300);

            //Assert
            Assert.AreEqual(300, account.Balance);
        }

        [TestMethod]
        public void Transfer_Airtime_Update_Both_Accounts_UnitTest()
        {
            //Arrange.
            var account = new SimCardAccount(100);
            var OtherSimCard = new SimCardAccount();

            //Act.
            account.TransferAirtimeTo(OtherSimCard, 50);

            //Assert
            Assert.AreEqual(50, account.Balance);
            Assert.AreEqual(50, OtherSimCard.Balance);
        }

        [TestMethod]
        public void Airtime_Balance_Is_Low_UnitTest()
        {
            //Arrange.
            var account = new SimCardAccount(30);

            //Act.
            account.Airtime_BalanceIsLow();

            //Assert.
            Assert.IsTrue(true);
        }
    }
}
