using Microsoft.VisualStudio.TestTools.UnitTesting;
using WSUniversalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib.Tests
{
    [TestClass()]
    public class CalculationTests
    {
        [TestMethod()]
        public void GetQuantityForProductTest_1()
        {

            //подготовка
            Calculation clac = new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = 15;
            float w = 20f;
            float h = 45f;
            int expected = 114148;
            //test
            var actual = clac.GetQuantityForProduct(typeProduct, typeMaterial, count, w, h);
            //проверка
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetQuantityForProductTest4_Minus_1()
        {

            //подготовка
            Calculation clac = new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = 15;
            float w = -20f;
            float h = 45f;
            int expected = -1;
            //test
            var actual = clac.GetQuantityForProduct(typeProduct, typeMaterial, count, w, h);
            //проверка
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest2_Minus_1()
        {

            //подготовка
            Calculation clac = new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = 15;
            float w = -20f;
            float h = 45f;
            int expected = -1;
            //test
            var actual = clac.GetQuantityForProduct(typeProduct, typeMaterial, count, w, h);
            //проверка
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest3_Minus_1()
        {

            //подготовка
            Calculation clac = new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = 15;
            float w = 20f;
            float h = -45f;
            int expected = -1;
            //test
            var actual = clac.GetQuantityForProduct(typeProduct, typeMaterial, count, w, h);
            //проверка
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest5_Minus_1()
        {

            //подготовка
            Calculation clac = new Calculation();
            int typeProduct = 3;
            int typeMaterial = 1;
            int count = -15;
            float w = 20f;
            float h = 45f;
            int expected = -1;
            //test
            var actual = clac.GetQuantityForProduct(typeProduct, typeMaterial, count, w, h);
            //проверка
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest7_Minus_1()
        {

            //подготовка
            Calculation clac = new Calculation();
            int typeProduct = 3;
            int typeMaterial = -1;
            int count = 15;
            float w = 20f;
            float h = 45f;
            int expected = -1;
            //test
            var actual = clac.GetQuantityForProduct(typeProduct, typeMaterial, count, w, h);
            //проверка
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetQuantityForProductTest6_Minus_1()
        {

            //подготовка
            Calculation clac = new Calculation();
            int typeProduct = -3;
            int typeMaterial = 1;
            int count = 15;
            float w = 20f;
            float h = 45f;
            int expected = -1;
            //test
            var actual = clac.GetQuantityForProduct(typeProduct, typeMaterial, count, w, h);
            //проверка
            Assert.AreEqual(expected, actual);
        }
    }
}