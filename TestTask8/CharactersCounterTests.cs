using Task8;

namespace TestTask8
{
    public class CharactersCounterTests
    {
        CharactersCounter counter;

        [SetUp]
        public void Setup()
        {
            // arrange
            counter= new CharactersCounter();
        }

        [TestCase("", 0)]
        [TestCase("aAa", 3)]
        [TestCase("a a", 1)]
        [TestCase("asdffghjkl", 6)]
        [TestCase("asdf fghjkl", 6)]
        public void CountUnequalCharactersTest(string line, int expectedOutput)
        {
            // act
            int actualOutput = counter.CountUnequalCharacters(line);

            // assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase("")]
        [TestCase("5676234")]
        [TestCase("234!@#!")]
        [TestCase("[]\\")]
        public void CountConsecutiveIdenticalLetters_NoLetters(string line)
        {
            // act
            int actualOutput = counter.CountIdenticalLetters(line);

            // assert
            Assert.AreEqual(0, actualOutput);
        }

        [TestCase("asd", 1)]
        [TestCase("aAa", 1)]
        [TestCase("asd!ddsa", 2)]
        [TestCase("ghh hhhjkl", 5)]
        public void CountConsecutiveIdenticalLetters_LineWithLetters(string line, int expectedOutput)
        {
            // act
            int actualOutput = counter.CountIdenticalLetters(line);

            // assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestCase("")]
        [TestCase("asdfgh")]
        [TestCase("jhk@Af!!ds")]
        [TestCase("[]\\")]
        public void CountConsecutiveIdenticaldigits_NoDigits(string line)
        {
            // act
            int actualOutput = counter.CountIdenticalDigits(line);

            // assert
            Assert.AreEqual(0, actualOutput);
        }

        [TestCase("1234", 1)]
        [TestCase("jhgk1!1", 1)]
        [TestCase("jgk221111444", 4)]
        [TestCase("oo2 2232!!kl", 3)]
        public void CountConsecutiveIdenticalDigits_LineWithdigits(string line, int expectedOutput)
        {
            // act
            int actualOutput = counter.CountIdenticalDigits(line);

            // assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}