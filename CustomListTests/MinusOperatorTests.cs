using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class MinusOperatorTests
    {
        [TestMethod]
        public void MinusOperator_FirstListLongerThanSecond_RemovesSpecifiedValues()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            CustomList<string> secondList = new CustomList<string>();
            secondList.Add("Hello");
            CustomList<string> subtractedList = newList - secondList;
            CustomList<string> testList = new CustomList<string>();
            testList.Add("World");

            for (int i = 0; i < testList.Count; i++)
            {
                Assert.AreEqual(subtractedList[i], testList[i]);
            }
        }

        [TestMethod]
        public void MinusOperator_SecondListLongerThanFirst_RemovesSpecifiedValues()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");

            CustomList<string> secondList = new CustomList<string>();
            secondList.Add("Hello");
            secondList.Add("There");
            secondList.Add("Everyone");
            CustomList<string> subtractedList = newList - secondList;
            CustomList<string> testList = new CustomList<string>();
            testList.Add("World");


            for (int i = 0; i < testList.Count; i++)
            {
                Assert.AreEqual(subtractedList[i], testList[i]);
            }
        }

        [TestMethod]
        public void MinusOperator_FirstListHasDuplicates_OnlySingleInstanceRemoved()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            newList.Add("Hello");

            CustomList<string> secondList = new CustomList<string>();
            secondList.Add("Hello");
            CustomList<string> subtractedList = newList - secondList;
            CustomList<string> testList = new CustomList<string>();
            testList.Add("World");
            newList.Add("Hello");


            for (int i = 0; i < testList.Count; i++)
            {
                Assert.AreEqual(subtractedList[i], testList[i]);
            }
        }
    }
}
