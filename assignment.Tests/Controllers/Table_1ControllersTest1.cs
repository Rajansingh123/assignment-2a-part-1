using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//required refrences
using System.Web.Mvc;
using assignment.Controllers;
namespace assignment.Tests.Controllers
{
    /// <summary>
    /// Summary description for Table_1ControllersTest1
    /// </summary>
    [TestClass]
    public class Table_1ControllersTest1
    {
       [TestMethod] 
       public void IndexLoadsValis()
        {
            //Arrange
            Table_1Controller controller = new Table_1Controller();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
