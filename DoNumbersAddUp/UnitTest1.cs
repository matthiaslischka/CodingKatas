using FluentAssertions;
using Xunit;

namespace DoNumbersAddUp
{
    public partial class UnitTest1
    {
        [Fact]
        public void EmptyArrayAddUpToOne_ShouldReturnFalse()
        {
            new Calculator().DoNumbersAddUp(new int[0], 1).Should().BeFalse();
        }

        [Fact]
        public void EmptyArrayAddUpToZero_ShouldReturnFalse()
        {
            new Calculator().DoNumbersAddUp(new int[0], 0).Should().BeFalse();
        }

        //Todo: Clarify
        // Does array [1] add up to 1?
        // Assumption: No. You can't take imaginary zero as second number. Otherwise [1,2] would sum up to 2 because of imaginary zero as well.
        [Fact]
        public void ArrayWithOneAddUpToOne_ShouldReturnFalse()
        {
            new Calculator().DoNumbersAddUp(new int[] { 1 }, 1).Should().BeFalse();
        }

        // Todo: Clarify
        // Does null/empty array result to sum 0?
        // Assumption: No.
        [Fact]
        public void NullArrayAddUpToZero_ShouldReturnFalse()
        {
            new Calculator().DoNumbersAddUp(null, 0).Should().BeFalse();
        }

        [Fact]
        public void NullArrayAddUpToOne_ShouldReturnFalse()
        {
            new Calculator().DoNumbersAddUp(null, 1).Should().BeFalse();
        }

        [Theory]
        [InlineData(new[] { 1, 1 }, 2)]
        [InlineData(new[] { 1, 1, 1 }, 2)]
        public void TwoNumbersOfArray_ShouldAddUpToSum(int[] array, int sum)
        {
            new Calculator().DoNumbersAddUp(array, sum).Should().BeTrue();
        }
    }
}
