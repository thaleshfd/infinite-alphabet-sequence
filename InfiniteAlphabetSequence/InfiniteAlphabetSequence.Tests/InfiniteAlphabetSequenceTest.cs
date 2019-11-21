using InfiniteAlphabetSequenceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class InfiniteAlphabetSequenceTest
    {
        [TestMethod]
        public void WhenStringEmpty_ReturnFirstAlphabetLetter()
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

        [TestMethod]
        public void WhenNotCapitalAndLastAlphabetLetter_StartsFromTheBegining()
        {
            var sequence = InfiniteAlphabetSequence.Generate("z");
            Assert.AreEqual("aa", sequence);
        }

        [TestMethod]
        public void WhenNotCapitalAndIfSequenceWithOneCharacter_ReturnNextOfTheSequence()
        {
            var sequence = InfiniteAlphabetSequence.Generate("g");
            Assert.AreEqual("h", sequence);
        }

        [TestMethod]
        public void WhenNotCapitalIfSequenceWithMoreThanOneCharacter_ReturnNextOfTheSequence()
        {
            var sequence = InfiniteAlphabetSequence.Generate("ghij");
            Assert.AreEqual("ghik", sequence);
        }
    }
}
