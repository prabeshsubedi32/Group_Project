using System;
using System.Web.Mvc;
using DynamicVendors.Controllers;
using DynamicVendors.Models;
using DynamicVendors.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DV.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            //A  - Arrange
            DynamicVendor data = new DynamicVendor();

            //A - Act
            Admin admin = new Admin();
            admin.Name = "Test from UT";
            int bc = data.GetAdmin().Count;
            data.Add(admin);
            int fc = data.GetAdmin().Count;
            //A  -Assert
            Assert.AreEqual(bc + 1, fc);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //A  - Arrange
            DynamicVendor data = new DynamicVendor();

            //A - Act
            Admin admin = new Admin();
            admin.Name = "Test from UT -VE";
            int bc = data.GetAdmin().Count;
            data.Add(admin);
            int fc = data.GetAdmin().Count;
            //A  -Assert
            Assert.AreEqual(bc, fc);

        }

        [TestMethod]
        public void TestMethodcONTRL()
        {
            // Arrange
         //  dynamicVendor
            AdminController controller = new AdminController(null);
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
          
        }
    }
}
