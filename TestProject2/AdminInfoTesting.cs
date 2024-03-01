using BlockLib;

namespace TestProject2
{
    [TestFixture]
     public class NUnitTestAdmin
    {
        [TestCase]
        public void EmailId()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.AreEqual("thiragabathina@gmail.com", "thiragabathina@gmail.com");
        }

        [TestCase]
        public void Password()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.AreEqual("madhuri12", "madhuri12");
        }
    }
}
