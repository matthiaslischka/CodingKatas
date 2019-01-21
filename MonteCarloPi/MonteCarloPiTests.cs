using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace MonteCarloPi
{
    public class MonteCarloPiTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public MonteCarloPiTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void CalculatePi()
        {
            var pi = new MonteCarloPi().CalculatePi(100000);
            _testOutputHelper.WriteLine("pi: "+ pi.ToString("0.000"));
        }

        [Fact]
        public void GetRandomPoint_ReturnsPoint()
        {
            var randomPoint = new MonteCarloPi().GetRandomPoint();
            randomPoint.Should().NotBeNull();
        }

        [Theory]
        [InlineData(0, 0, true)]
        [InlineData(-1, -1, false)]
        [InlineData(0, -1, true)]
        [InlineData(1, 0, true)]
        [InlineData(0.2, 0.2, true)]
        [InlineData(1, 1, false)]
        public void IsPointInCircle_ReturnsTrueOrFalse(decimal x, decimal y, bool expectedInCircle)
        {
            var point = new MonteCarloPi.Point { X = x, Y = y };
            var monteCarloPi = new MonteCarloPi();

            var actualIsPointInCircle = monteCarloPi.IsPointInCircle(point);

            actualIsPointInCircle.Should().Be(expectedInCircle);
        }
    }
}
