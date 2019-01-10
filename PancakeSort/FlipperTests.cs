using FluentAssertions;
using Xunit;

namespace PancakeSort
{
    public class FlipperTests
    {
        [Fact]
        public void EmptyArray_ShouldReturnEmptyArray()
        {
            Flip(new int[0], 0).Should().BeEmpty();
        }

        [Fact]
        public void ArrayWithOneElement_ShouldReturnArrayWithOneElement()
        {
            Flip(new int[1], 0).Should().HaveCount(1);
        }

        [Fact]
        public void ArrayWithTwoElements_ShouldReturnArrayWithTwoElements()
        {
            Flip(new int[2], 0).Should().HaveCount(2);
        }

        [Fact]
        public void ArrayWithFlip1_ShouldReturnUnchanged()
        {
            AssertFlip(new[] { 1, 2, 3 }, 1, new[] { 1, 2, 3 });
        }

        [Fact]
        public void TwoSizedArrayWithFlip2_ShouldFlipTheNumbers()
        {
            AssertFlip(new[] { 1, 2 }, 2, new[] { 2, 1 });
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3 }, 3, new int[] { 3, 2, 1 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 3, new int[] { 3, 2, 1, 4 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 4, new int[] { 4, 3, 2, 1 })]
        [InlineData(new[] { 1, 2, 3, 4 }, 2, new int[] { 2, 1, 3, 4 })]
        public void ArrayFlip_ShouldFlipNumber(int[] arr, int k, int[] expectedArray)
        {
            AssertFlip(arr, k, expectedArray);
        }

        private int[] Flip(int[] arr, int k)
        {
            return new Flipper().Flip(arr, k);
        }

        private void AssertFlip(int[] arr, int k, int[] expectedArray)
        {
            Flip(arr, k).Should().BeEquivalentTo(expectedArray, config => config.WithStrictOrdering());
        }
    }
}
