using System;
using System.Collections.Generic;
using System.Data.Entity;
using Lab.Demo.Data;
using Lab.Demo.Entities;
using Lab.Demo.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
            var shipper = testLogic.GetByID(4);

            //Assert is handled by the exception.
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestGetShipperByIDFe() 
        {
            //Arrange
            ShippersLogic testLogic = new ShippersLogic();

            //Act
            var shipper = testLogic.GetByID(int.Parse("a"));

            //Assert is handled by the exception.
        }
        [TestMethod]
        public void TestGetAll()
        {
            //Arrange
            ShippersLogic testlogic = new ShippersLogic();
            List<Shipper> testList = testlogic.GetAll();

            //Assert
            Assert.IsInstanceOfType(testList, typeof(List<Shipper>));
        }

        [TestMethod]
        public void TestGetByID_Success()
        {
            //Arrange
            Shipper actual = new Shipper()
            {
                ShipperID = 1,
                CompanyName = "Test Shipper",
                Phone = "(503) 555-5588"
            };
            Shipper expected = new Shipper()
            {
                ShipperID = 1,
                CompanyName = "Test Shipper",
                Phone = "(503) 555-5588"
            };
            Mock<ShippersLogic> mockShippersLogic = new Mock<ShippersLogic>();

            //Action
            mockShippersLogic.Setup(x => x.GetByID(actual.ShipperID)).Returns(actual);
                
            //Assert
            Assert.AreEqual(expected.ShipperID, mockShippersLogic.Object.GetByID(1).ShipperID);
            Assert.AreEqual(expected.CompanyName, mockShippersLogic.Object.GetByID(1).CompanyName);
            Assert.AreEqual(expected.Phone, mockShippersLogic.Object.GetByID(1).Phone);
        }
    }
}
