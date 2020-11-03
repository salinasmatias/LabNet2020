using System;
using System.Collections.Generic;
using Lab.Demo.Entities;
using Lab.Demo.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NorthwindTest
{
    [TestClass]
    public class Northwind_Test
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestGetShipperByIDOp()
        {
            //Arrange
            ShippersLogic testLogic = new ShippersLogic();

            //Act
            var shipper = testLogic.GetShipperByID(4);

            //Assert is handled by the exception.
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestGetShipperByIDFe() 
        {
            //Arrange
            ShippersLogic testLogic = new ShippersLogic();

            //Act
            var shipper = testLogic.GetShipperByID(int.Parse("a"));

            //Assert is handled by the exception.
        }
    }
}
