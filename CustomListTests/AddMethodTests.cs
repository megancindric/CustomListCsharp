using CustomList;
namespace CustomListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_AddOneItem_IncrementCountByOne()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");

            Assert.AreEqual(1, newList.Count);
        }

        [TestMethod]
        public void AddMethod_AddTwoItems_ItemsAtProperIndex()
        {
            CustomList<int> newList = new CustomList<int>();
            newList.Add(9);
            newList.Add(8);
            Assert.AreEqual(9, newList[0]);
            Assert.AreEqual(8, newList[1]);
        }

        [TestMethod]
        public void AddMethod_AddItemBeyondCapacity_CapacityDoubles()
        {
        CustomList<int> newList = new CustomList<int>();
        newList.Add(1);
        newList.Add(2);
        newList.Add(3);
        newList.Add(4);
        newList.Add(5);
        Assert.AreEqual(8, newList.Capacity);

    }

    [TestMethod]
        public void AddMethod_AddItemBeyondCapacity_PreviousItemsExist()
        {
        CustomList<int> newList = new CustomList<int>();
        newList.Add(1);
        newList.Add(2);
        newList.Add(3);
        newList.Add(4);
        newList.Add(5);
        Assert.AreEqual(3, newList[2]);
    }
    }
}