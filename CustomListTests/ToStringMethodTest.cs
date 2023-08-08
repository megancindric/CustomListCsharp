using CustomList;

namespace CustomListTests
{
    [TestClass]

    public class ToStringMethodTest
    {
        [TestMethod]
        public void ToStringMethod_CallingToStringOnStringList_ReturnsStringOfValues()
        {
            CustomList<string> newList = new CustomList<string>();
            newList.Add("Hello");
            newList.Add("World");
            string stringifiedList = newList.ToString();
            Assert.AreEqual("HelloWorld", stringifiedList);

        }
        [TestMethod]
        public void ToStringMethod_CallingToStringOnIntList_ReturnsStringOfValues()
        {
            CustomList<int> newList = new CustomList<int>();
            newList.Add(1);
            newList.Add(2);
            string stringifiedList = newList.ToString();
            Assert.AreEqual("12", stringifiedList);
        }
        [TestMethod]
        public void ToStringMethod_CallingOnEmptyList_ReturnsEmptyString()
        {
            CustomList<string> newList = new CustomList<string>();

            string stringifiedList = newList.ToString();
            Assert.AreEqual("", stringifiedList);
        }
    }
}
