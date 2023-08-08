using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTests
{
    [TestClass]

    internal class PlusOperatorTests
    {
        [TestMethod]
        public void PlusOperator_FirstListLongerThanSecond_CombinesLists()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            CustomList<string> secondList = new CustomList<string>();
            secondList.Add("Hola");
            CustomList<string> combinedList = newList + secondList;
            CustomList<string> testList = new CustomList<string>();
            testList.Add("Hello");
            testList.Add("World");
            testList.Add("Hola");
            for (int i = 0; i < testList.Count; i++)
            {
                Assert.AreEqual(combinedList[i], testList[i]);
            }

        }
        [TestMethod]
        public void PlusOperator_SecondListLongerThanFirst_CombinesLists()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            CustomList<string> secondList = new CustomList<string>();
            secondList.Add("Hola");
            secondList.Add("World");
            CustomList<string> combinedList = newList + secondList;
            CustomList<string> testList = new CustomList<string>();
            testList.Add("Hello");
            testList.Add("Hola");
            testList.Add("World");
            for (int i = 0; i < testList.Count; i++)
            {
                Assert.AreEqual(combinedList[i], testList[i]);
            }
        }
        [TestMethod]
        public void PlusOperator_SecondListEmpty_DoesNotChangeResult()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            CustomList<string> secondList = new CustomList<string>();
            CustomList<string> combinedList = newList + secondList;

            CustomList<string> testList = new CustomList<string>();
            testList.Add("Hello");
            testList.Add("World");
            for (int i = 0; i < testList.Count; i++)
            {
                Assert.AreEqual(combinedList[i], testList[i]);
            }
            Assert.AreEqual(newList.Count, combinedList.Count);
        }
    }
}
