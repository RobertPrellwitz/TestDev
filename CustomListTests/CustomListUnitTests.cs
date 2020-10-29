using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListUnitTestStarter;

namespace CustomListTests
{
    [TestClass]
    public class CustomListUnitTests
    {
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 10;
            int actual;

            // Act
            testList.Add(item);
            actual = testList[0]; // error expected until "indexer property" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsToOne()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            int item = 10;
            int expected = 1;
            int actual;

            // Act
            testList.Add(item);
            actual = testList.Counter; // error expected until "Count" is added to class

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ItemToExistingList_CountIncrements()
        {
            CustomList<int> testList = new CustomList<int>();
            int item = 15;

            int expected = 3;
            int actual;

            testList.Add(item);
            testList.Add(item);
            testList.Add(item);

            actual = testList.Counter;



            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_ItemToExistingList_itemInIndex2()
        {
            CustomList<int> testList = new CustomList<int>();
            int item = 15;

            int expected = 20;
            int actual;

            testList.Add(item);
            testList.Add(item);
            testList.Add(20);

            actual = testList[2];



            Assert.AreEqual(expected, actual);
        }


        //When should capacity increase?
        //Add 5 items, then test capacity, should be 8
        [TestMethod]
        public void Add_ItemToExistingList_CapacityIncrease()
        {
            CustomList<int> testList = new CustomList<int>();
            int item = 15;

            int expected = 8;
            int actual;

            testList.Add(10);
            testList.Add(item);
            testList.Add(20);
            testList.Add(25);
            testList.Add(30);

            actual = testList.Capacity;



            Assert.AreEqual(expected, actual);
        }

        //Add 5 items, 5th item goes where we want
        [TestMethod]
        public void Add_ItemToExistingListToIncreaseCapacity_IsLocationCorrect()
        {
            CustomList<int> testList = new CustomList<int>();
            int item = 15;

            int expected = 30;
            int actual;

            testList.Add(10);
            testList.Add(item);
            testList.Add(20);
            testList.Add(25);
            testList.Add(30);

            actual = testList[4];



            Assert.AreEqual(expected, actual);
        }


        //Add 5 items, one of the first 4 items is still where it was

        [TestMethod]
        public void Add_ItemToExistingList_IsLocationofOriginalCorrect()
        {
            CustomList<int> testList = new CustomList<int>();
            int item = 15;

            int expected = 15;
            int actual;

            testList.Add(10);
            testList.Add(item);
            testList.Add(20);
            testList.Add(25);
            testList.Add(30);

            actual = testList[1];



            Assert.AreEqual(expected, actual);
        }



        // what if i .Add to a list that has a couple things in it already (value of Count)?
        // how does the Capacity change as you add things? (starts at 4, and doubles)

        // REMOVE TESTS:
        [TestMethod]
        public void RemoveItemFromList_CountCheck()
        {
            CustomList<int> testList = new CustomList<int>();
            int item = 15;

            int expected = 4;
            int actual;

            testList.Add(10);
            testList.Add(item);
            testList.Add(20);
            testList.Add(25);
            testList.Add(30);

            testList.removeItem(item);

            actual = testList.Counter;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveItemFromList_RemoveCorrectItem()
        {
            string actualString;
            string expectedString;
            
            int item = 15;
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual = new CustomList<int>();

            testList.Add(10);
            testList.Add(item);
            testList.Add(20);
            testList.Add(25);
            testList.Add(15);
            testList.Add(30);

            expected.Add(10);
            expected.Add(20);
            expected.Add(25);
            expected.Add(15);
            expected.Add(30);

            testList.removeItem(item);

            actual = testList;

            actualString = actual.ConvertToString(actual);
            expectedString = expected.ConvertToString(expected);

            Assert.AreEqual(expectedString, actualString);



            
        }
        [TestMethod]
        public void RemoveItemFromEmpty_RemoveCorrectItem()
        {

            string actualString;
            string expectedString;
            CustomList<int> testList = new CustomList<int>();
            int item = 15;

            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual;

            testList.Add(10);
            testList.Add(item);

            testList.removeItem(10);
            testList.removeItem(item);
            testList.removeItem(item);

            actual = testList;


            actualString = actual.ConvertToString(actual);
            expectedString = expected.ConvertToString(expected);

            Assert.AreEqual(expectedString, actualString);

        }

        [TestMethod]
        public void AddTwoLists()
        {
            string actualString;
            string expectedstring;
            CustomList<int> actual;
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);

            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(15);
            testList2.Add(30);
            testList2.Add(45);

            CustomList<int> expected = new CustomList<int>();
            expected.Add(10);
            expected.Add(15);
            expected.Add(20);
            expected.Add(15);
            expected.Add(30);
            expected.Add(45);

            actual = testList + testList2;

            actualString = actual.ConvertToString(actual);
            expectedstring = expected.ConvertToString(expected);

            Assert.AreEqual(expectedstring, actualString);
            

        }

        [TestMethod]
        public void ZipTwoLists()
        {
            string actualString;
            string expectedString;
            CustomList<int> tempList =new CustomList<int>();
            
            CustomList<int> actual;
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(3);
            testList.Add(5);
            testList.Add(7);

            CustomList<int> testList2 = new CustomList<int>();
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);

            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);
            expected.Add(6);
            expected.Add(7);

            actual= tempList.ZipTwoLists(testList, testList2);

            actualString = actual.ConvertToString(actual);
            expectedString = expected.ConvertToString(expected);

            Assert.AreEqual(expectedString, actualString);


        }
        [TestMethod]
        public void SubTwoLists()
        {
            CustomList<int> actual;
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);

            CustomList<int> testList2 = new CustomList<int>();
            testList.Add(15);
            testList.Add(30);
            testList.Add(45);

            CustomList<int> expected = new CustomList<int>();
            testList.Add(10);
            testList.Add(20);
            
            actual = testList - testList2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertToString()
        {
           
            CustomList<int> testList = new CustomList<int>();
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(30);
            testList.Add(45);

            string expected = "10, 15, 20, 30, 45";
            string actual = testList.ConvertToString(testList);

            Assert.AreEqual(expected, actual);


        }

    }
}
