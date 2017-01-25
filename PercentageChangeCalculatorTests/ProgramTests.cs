﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PercentageChangeCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageChangeCalculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalculatePercentageChangeTest()
        {
            //arrange
            decimal numberOrig = 21;
            decimal numberNew = 15;
            decimal calculatedResult;
            decimal expectedResult = -28.571428571428571428571428570M;

            //act
            calculatedResult = PercentageChangeCalculator.Program.CalculatePercentageChange(numberOrig, numberNew);

            //assert
            Console.WriteLine($"calculated result is {calculatedResult}");


            if (calculatedResult != expectedResult)
            {
                Assert.Fail();
            }


        }
    }
}