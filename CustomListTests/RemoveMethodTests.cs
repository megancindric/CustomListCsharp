using CustomList;

namespace CustomListTests
{
    [TestClass]

    public class RemoveMethodTests
    {
        [TestMethod]
        public void RemoveMethod_RemoveOneItem_CountDecreasesByOne()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            Assert.AreEqual(2, newList.Count);
            newList.Remove("World");
            Assert.AreEqual(1, newList.Count);
        }
        [TestMethod]
        public void RemoveMethod_RemoveOneItem_MethodReturnsTrue()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            bool result = newList.Remove("World");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void RemoveMethod_RemoveItemThatDoesntExist_CountDoesNotDecrement()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            newList.Remove("Hola");
            Assert.AreEqual(2, newList.Count);
        }
        [TestMethod]
        public void RemoveMethod_RemoveItemIndexZero_IndexOneNowAtIndexZero()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            newList.Remove("Hello");
            Assert.AreEqual("World", newList[0]);
        }
        [TestMethod]
        public void RemoveMethod_RemoveItemWithMultiples_OnlyOneInstanceRemoved()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("Hello");
            newList.Add("Hello");
            newList.Remove("Hello");
            Assert.AreEqual("Hello", newList[0]);
        }
    }
}
