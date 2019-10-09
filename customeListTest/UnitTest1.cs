using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customeLIST; 


namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {
        // unit test for adding multiple items to check position of last item
        // unit test for adding multiple items to check Count property
        // unit test for adding number of items beyond 'Capacity' but it still adds

        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToLastIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 13;
            int actual;

            // act
            testList.Add(12);
            testList.Add(13);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(234);
            actual = testList.capacity;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddMultipleItemToList_CountIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(234);
            testList.Add(235);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
       
        public void Add_AddMoreitemsThenCapacity_Capacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            int actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
            testList.Add(237);
            testList.Add(238);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_AddMoreitemsDoubleCapacity_Capacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 10;
            int actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
            testList.Add(237);
            testList.Add(238);
            testList.Add(238);
            testList.Add(238);
            testList.Add(238);
            testList.Add(238);
            testList.Add(238);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Remove_CheckToSeeIfRemovedFromTheEnd_Capacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 235;
            int actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Remove(234);

            actual = testList[0];

            // assert
           Assert.AreEqual(expected, actual);
   
        }
        [TestMethod]
        public void Remove_CheckToSeeIfCountDecreases_Count()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Remove(235);
            
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_CheckToSeeIfRemovedFromTheEndIfMultipleRemoved_Capacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 236;
            int actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
            testList.Remove(234);
            testList.Remove(235);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_CheckToSeeIfMultipleOfSameOnlyOneRemoved_Count()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(235);
            testList.Remove(235);
            

            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_CheckToSeeIfMultipleOfSameRemovesFirstOne_Count()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 234;
            int actual;

            // act
            testList.Add(235);
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
            testList.Add(235);
            testList.Remove(235);
            

            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_CheckToSeeIfMultipleRemovedCountDecreases_Count()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(235);
            testList.Remove(235);
            testList.Remove(235);

            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_CheckToSeeIfInvalidRemove_false()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            bool expected = false;
            bool actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(235);
            testList.Remove(235);
            testList.Remove(235);

            actual = testList.Victory;

            // assert
            Assert.AreEqual(expected, actual);

        }

    }    
}

