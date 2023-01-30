using Animal.Models;
using Xunit;

namespace UnitTest
{
    public class AnimalSoundTest
    {
        [Fact]
        public void DogSoundTest()
        {
            string expected = "Woof";
            string actual = new Dog().Sound();

            Assert.Contains(expected, actual);
        }

        [Fact]
        public void CatSoundTest()
        {
            string expected = "Meow";
            string actual = new Cat().Sound();

            Assert.Contains(expected, actual);
        }

        [Theory]
        [InlineData("Meow")]
        [InlineData("Woof")]
        public void AnimalSoundTheoryTest(string sound)
        {
            Assert.Contains(sound, new List<string> { new Cat().Sound(), new Dog().Sound() });
        }
    }
}