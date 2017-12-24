using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//required refrences
using System.Web.Mvc;
using assignment.Controllers;
using Moq;
using assignment.Models;
using System.Linq;

namespace assignment.Tests.Controllers
{
    /// <summary>
    /// Summary description for Table_1ControllersTest1
    /// </summary>
    [TestClass]
    public class Table_1ControllersTest1
    {
        Table_1Controller controller;
        Mock<ITable_1Repository> mock;
        List<Table_1> table_1;
        [TestInitialize]
        public void TestInitialize()
        {

            mock = new Mock<ITable_1Repository>();

            //mock data
            table_1 = new List<Table_1>
            {
                new Table_1 {Carid = 1, companyname = "TATA", price =20000},

                new Table_1 {Carid = 2, companyname = "TATA", price =20000},
            };
          
            mock.Setup(m => m.Table_1).Returns(table_1.AsQueryable());
            controller = new Table_1Controller(mock.Object);
        }
        [TestMethod] 
       public void IndexLoadsValis()
        {
            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Indexshowvalidcars()
        {
            //act
            var actual = (List<Table_1>)controller.Index().Model;

            CollectionAssert.AreEqual(table_1, actual);
        }

        [TestMethod]
        public void DetailsValidTable1()
        {
            //act
            var actual = (Table_1)controller.Details(1).Model;
            //assert
            Assert.AreEqual(table_1.ToList()[0], actual);
        }
        [TestMethod]
            public void DetailsInvalidId()
        {
            //act
            var actual = controller.Details(3);

            //assert
            Assert.AreEqual("Error", actual.ViewName);
        }
        [TestMethod]
        public void DetailsInvalidNoId()
        {
            //act
            var actual = controller.Details(null);

            //assert
            Assert.AreEqual("Error", actual.ViewName);
        }

        [TestMethod]
        public void DeleteConfirmedNoId()
        {
            //act
            ViewResult actual = controller.DeleteConfirmed(null);
            //assert
            Assert.AreEqual("Error", actual.ViewName);
        }
        [TestMethod]
        public void DeleteConfirmedInvalidId()
        {
            //act
            ViewResult actual = controller.DeleteConfirmed(3);
            //assert
            Assert.AreEqual("Error", actual.ViewName);
        }
        [TestMethod]
        public void DeleteConfirmedValidId()
        {
            //act
            ViewResult actual = controller.DeleteConfirmed(1);
            //assert
            Assert.AreEqual("Index", actual.ViewName);
        }

       
    }

}
