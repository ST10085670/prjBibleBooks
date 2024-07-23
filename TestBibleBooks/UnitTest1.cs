using prjBible;

namespace TestBibleBooks
{
    
    [TestClass]
    public class UnitTest1
    {
        private BibleBooks books = new BibleBooks("John", 3, "16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        [TestMethod]
        public void TestBook()
        {
            object Actual = books[index: 0];
            string Expected = "John";
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestChapter()
        {
            object Actual = books[index: 2];
            int Expected = 3;
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestVerseNumber()
        {
            object Actual = books[index: 3];
            string Expected = "16";
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestVerse()
        {
            object Actual = books[index: 1];
            string Expected = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestBookWrong() 
        {
            object Actual = books[index: 0];
            string NotExpected = "Matthew";
            Assert.AreEqual(NotExpected, Actual);
        }
    }
}