//using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantManagementSystem;
using System;
using System.Data;
using NUnit.Framework;
using RestaurantManagementSystem.AllUserControls;

namespace TestApp.UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        OperationsManager pc;
        [SetUp]
        public void setup()
        {
            function fn = new function();
            pc = new OperationsManager();
        }

        [Test] 
        [TestCase(1,100,100)]
        [TestCase(5,50,250)]
        [TestCase(8, 80, 640)]
        public void CheckPrice(long qty,long price,long expected)
        {
            var result = pc.priceCalc(qty,price);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("saksham","pass","Admin")]
        [TestCase("saksham", "wrong pass", "")]
        public void CheckLogin(string uname,string pass,string expected)
        {
            var result = pc.validateLogin(uname, pass);
            Assert.That(result, Is.EqualTo(expected));
        }



    }
}
