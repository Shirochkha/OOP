using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class ParalTests
    {

        [TestMethod()]
        public void IsExistTest1() // #1 существование фигуры
        {
            Parallelogram testA = new Parallelogram(2, 2, 7, 2, 9, 5, 4, 5);
            Assert.IsFalse(testA.IsExist());
        }
        [TestMethod()]
        public void IsExistTest2() // #2 существование фигуры
        {
            Parallelogram testA = new Parallelogram(2, 2, 7, 2, 9, 5, 8, 8);
            Assert.IsFalse(testA.IsExist());
        }

        [TestMethod()]
        public void IsPointBelongTest1() // #1 проверка на принадлежность точки 
        {
            Parallelogram testA = new Parallelogram(2, 2, 7, 2, 9, 5, 4, 5);
            Assert.IsTrue(testA.IsPointBelong(0, 0));
        }
        public void IsPointBelongTest2() // #2 проверка на принадлежность точки 
        {
            Parallelogram testA = new Parallelogram(2, 2, 7, 2, 9, 5, 4, 5);
            Assert.IsTrue(testA.IsPointBelong(4, 3));
        }
        public void IsPointBelongTest3() // #3 проверка на принадлежность точки 
        {
            Parallelogram testA = new Parallelogram(2, 2, 7, 2, 9, 5, 4, 5);
            Assert.IsFalse(testA.IsPointBelong(4, 5));
        }

        [TestMethod()]
        public void GetPerimetrTest() // проверка на периметр
        {
            Parallelogram testA = new Parallelogram(2, 2, 7, 2, 9, 5, 4, 5);
            Assert.AreEqual(testA.PerimetrCalculation(), 17.211, 0.01);
        }

        [TestMethod()]
        public void GetSquareTest() // проверка на площадь
        {
            Parallelogram testA = new Parallelogram(2, 2, 7, 2, 9, 5, 4, 5);
            Assert.AreEqual(testA.SquareCalculation(), 15, 0.001);
        }
    }
}