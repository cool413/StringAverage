using FluentAssertions;
using NUnit.Framework;
using StringAverage;

namespace UnitTest
{
    public class StringAverageTests
    {
        private StringAverager _stringAverager;
        
        private const string InvalidString = "n/a";
        
        [SetUp]
        public void Setup()
        {
            _stringAverager = new StringAverager();
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("Ten")]
        public void Can_invalid_input(string input)
        {
           var result = _stringAverager.AverageString(input);
           result.Should().Be(InvalidString);
        }
        
        [Test]
        [TestCase("zero nine five two", "four")]
        [TestCase("four six two three", "three")]
        public void Can_get_average_floored_String(string input, string expect)
        {
            var result = _stringAverager.AverageString(input);
            result.Should().Be(expect);
        }
    }
}