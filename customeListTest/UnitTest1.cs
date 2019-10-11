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

       
        [TestMethod]
        public void ToString_CheckToSeeIfIntListBecomesString_ToString()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "234,235,236,";
            string actual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
             
            
            actual = testList.ToString();


            
           

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ToString_CheckToSeeIfBoolListBecomesString_ToString()
        {
            // arrange
            CustomList<bool> testList = new CustomList<bool>();
            string expected = "True,True,False,";
            string actual;
            bool A = true;
            bool B = true;
            bool C = false;

            // act
            testList.Add(A);
            testList.Add(B);
            testList.Add(C);


            actual = testList.ToString();





            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ToString_CheckToSeeIfStringListBecomesString_Addition()
        {
            // arrange
            CustomList<string> testList = new CustomList<string>();
            string expected = "pizza,poptart,popcorn,";
            string actual;
           

            // act
            testList.Add("pizza");
            testList.Add("poptart");
            testList.Add("popcorn");


            actual = testList.ToString();





            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Combine_combineTwoList_Addiition()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int expected = 237;
            int actual;

            // act
            testList.Add(234);
            testList2.Add(237);
            CustomList<int> NewList = testList + testList2;
             actual = NewList[1]; 

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Combine_combineTwoListWithMultipleItems_Addition()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> NewList;
            int expected = 237;
            int acutual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
            testList2.Add(237);
            testList2.Add(238);
            testList2.Add(239);
            NewList = testList + testList2;
            acutual = NewList[3];

            // assert
            Assert.AreEqual(expected, acutual);

        }
            
            [TestMethod]
        public void Subtraction_RemoveTwoListWithOneItem_Subtraction()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int expected = 236;
            int actual;

            // act
            testList.Add(236);
            testList.Add(234);
            testList2.Add(234);
            CustomList<int> NewList = testList - testList2;
            actual = NewList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtraction_RemoveListWithMultipleItems_Subtraction()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> NewList;
            int expected = 237;
            int acutual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
            testList2.Add(237);
            testList2.Add(238);
            testList2.Add(239);
            NewList = testList + testList2;
            acutual = NewList[3];

            // assert
            Assert.AreEqual(expected, acutual);
        }
        [TestMethod]
        public void Zipper_ZipTwoListWithMultipleItems_Zipper()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int[] NewList;
            int expected = 237;
            int acutual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
            testList2.Add(237);
            testList2.Add(238);
            testList2.Add(239);
            NewList = CustomList<int>.Zipper(testList, testList2);
            acutual = NewList[1];

            // assert
            Assert.AreEqual(expected, acutual);

        }
        [TestMethod]
        public void Zipper_ZipTwoListWithUnevenAmmountsMultipleItems_Zipper()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int[] NewList;
            int expected = 242;
            int acutual;

            // act
            testList.Add(234);
            testList.Add(235);
            testList.Add(236);
            testList2.Add(237);
            testList2.Add(238);
            testList2.Add(239);
            testList2.Add(240);
            testList2.Add(241);
            testList2.Add(242);
            NewList = CustomList<int>.Zipper(testList, testList2);
            acutual = NewList[8];

            // assert
            Assert.AreEqual(expected, acutual);

        }

    }

}

