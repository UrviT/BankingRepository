using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankingLibrary;

namespace BankingLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void Calculate_AcceptsPNR_returnsSimpleInterest()
        {
            //Arrange
            int ExpectedResult = 1000;
            //Act
            ICalcInterest calcInterest = new CalcInterest();
            int ActualResult = calcInterest.Calculate(1000, 10, 10);
            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
