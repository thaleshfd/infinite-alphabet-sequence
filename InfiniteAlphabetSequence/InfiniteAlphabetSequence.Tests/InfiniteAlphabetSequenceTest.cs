using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfiniteAlphabetSequence.Tests
{
    [TestClass]
    public class InfiniteAlphabetSequenceTest
    {
        [TestMethod]
        public void WhenStringEmpty_ReturnFirstCapitalAlphabetLetter()
        {
            var sequence = InfiniteAlphabetSequence.Generate("");
            Assert.AreEqual("A", sequence);
        }

        [TestMethod]
        public void WhenLastAlphabetLetter_StartsFromTheBegining()
        {
            var sequence = InfiniteAlphabetSequence.Generate("Z");
            Assert.AreEqual("AA", sequence);
        }

        [TestMethod]
        public void IfNotCapitalAndStringEmpty_ReturnFirstAlphabetLetter()
        {
            var sequence = InfiniteAlphabetSequence.Generate("", false);
            Assert.AreEqual("a", sequence);
        }

        [TestMethod]
        public void IfSequenceWithOneCharacter_ReturnNextOfTheSequence()
        {
            var sequence = InfiniteAlphabetSequence.Generate("G");
            Assert.AreEqual("H", sequence);
        }

        [TestMethod]
        public void IfSequenceWithMoreThanOneCharacter_ReturnNextOfTheSequence()
        {
            var sequence = InfiniteAlphabetSequence.Generate("GHIJ");
            Assert.AreEqual("GHIK", sequence);
        }
    }
}
