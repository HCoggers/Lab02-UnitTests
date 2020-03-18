using System;
using Xunit;
using Lab02_UnitTests;

namespace ATMTests
{
    public class UnitTest1
    {
        // WITHDRAW TESTS
        [Fact]
        public void CanTake100From200()
        {
            Assert.Equal(100, Program.Withdraw("100", 200));
        }
        [Fact]
        public void CantWithdrawNegatives()
        {
            Assert.NotEqual(150, Program.Withdraw("-50", 100));
        }
        [Fact]
        public void CantTakeMoreThanBalance()
        {
            // Checking for the type of exception thrown when withdrawing more than balance
            Assert.Throws<ArgumentException>(() => Program.Withdraw("100", 50));
        }
        // DEPOSIT TESTS
        [Fact]
        public void CanDeposit50()
        {
            Assert.Equal(150, Program.Deposit("50", 100));
        }
        [Fact]
        public void CantDepositNegatives()
        {
            Assert.NotEqual(50, Program.Deposit("-50", 100));
        }
    }
}
