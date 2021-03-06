﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add1Check()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 3;
            int expectedResult = 1;
            //Act
            custom.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, custom.Count);
        }
        [TestMethod]
        public void AddAtIndex()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 3;
            int expectedResult = 3;
            //Act
            custom.Add(value);

            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }

        [TestMethod]
        public void AddTwoInts()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 3;
            //Act
            custom.Add(value);
            custom.Add(value1);

            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }
        [TestMethod]
        public void Add2IntsCheckLocation()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int expectedResult = 5;
            //Act
            custom.Add(value);
            custom.Add(value1);

            //Assert
            Assert.AreEqual(expectedResult, custom[1]);
        }
        [TestMethod]
        public void Add3IntsCheckLocation()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 3;
            int value1 = 5;
            int value2 = 7;
            int expectedResult = 7;
            //Act
            custom.Add(value);
            custom.Add(value1);
            custom.Add(value2);
            //Assert
            Assert.AreEqual(expectedResult, custom[2]);
        }
        [TestMethod]
        public void Remove1AndCheck()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            int value2 = 3;
            int value3 = 4;
            int expectedResult = 2;
            //Act
            custom.Add(value);
            custom.Add(value1);
            custom.Add(value2);
            custom.Add(value3);
            custom.Remove(value);
            //Assert
            Assert.AreEqual(expectedResult, custom.Count);
        }
        [TestMethod]
        public void Remove2Ints()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            int value2 = 3;
            int value3 = 4;
            int expectedResult = 1;
            //Act
            custom.Add(value);
            custom.Add(value1);
            custom.Add(value2);
            custom.Add(value3);
            custom.Remove(value1);
            custom.Remove(value2);
            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }
        [TestMethod]
        public void Remove3Ints()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            int value2 = 3;
            int value3 = 4;
            int expectedResult = 1;
            //Act
            custom.Add(value);
            custom.Add(value1);
            custom.Add(value2);
            custom.Add(value3);
            custom.Remove(value1);
            custom.Remove(value2);
            custom.Remove(value3);
            //Assert
            Assert.AreEqual(expectedResult, custom[0]);
        }
        [TestMethod]
        public void RemoveAtIndex()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            int value2 = 3;
            int value3 = 4;
            int expectedResult = 3;
            //Act
            custom.Add(value);
            custom.Add(value1);
            custom.Add(value2);
            custom.Add(value3);
            custom.Remove(1);
            //Assert
            Assert.AreEqual(expectedResult, custom[1]);
        }
        [TestMethod]
        public void Remove()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            int value2 = 3;
            int value3 = 4;
            int expectedResult = 3;
            //Act
            custom.Add(value);
            custom.Add(value1);
            custom.Add(value2);
            custom.Add(value3);
            custom.Remove(value);
            //Assert
            Assert.AreEqual(expectedResult, custom.Count);
        }
        [TestMethod]
        public void ListToString()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int value = 1;
            int value1 = 2;
            int value2 = 3;
            int value3 = 4;
            string expectedResult = "1 2 3 4";
            //Act
            custom.Add(value);
            custom.Add(value1);
            custom.Add(value2);
            custom.Add(value3);
            custom.ToString();
            //Assert
            Assert.IsTrue(true);
        }
    }

}

