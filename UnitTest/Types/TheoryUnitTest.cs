using Xunit;

namespace UnitTest.Types
{
    public class TheoryUnitTest
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void MyTheory(int value)
        {
            Assert.True(IsOdd(value));
        }
        
        private bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
    }
}

