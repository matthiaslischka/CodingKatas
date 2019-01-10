using System;
using System.ComponentModel.Design;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace ArrayProduct
{
    public class ArrayManipulatorTests
    {
        private ArrayManipulator arrayManipulator = new ArrayManipulator();

        [Fact]
        public void EmptyArray_ShouldReturnEmptyArray()
        {
            GenerateArrayProducts(new int[] { }).Should().BeEquivalentTo(new int[] { });
        }

        [Fact]
        public void NullArray_ShouldReturnEmptyArray()
        {
            GenerateArrayProducts(null).Should().BeEquivalentTo(new int[] { });
        }

        [Fact]
        public void SingleDigitArray_ShouldReturnSingleDigitArray()
        {
            GenerateArrayProducts(new[] { 1 }).Should().BeEquivalentTo(new[] { 0 });
        }

        [Fact]
        public void ArrayWithTwoNumbers_ShouldReturnArrayWithTwoNumbers()
        {
            GenerateArrayProducts(new[] { 1, 2 }).Should().BeEquivalentTo(new[] { 2, 1 }, c => c.WithStrictOrdering());
        }

        [Fact]
        public void ArrayWithOnlyZeros_ShouldReturnArrayWithOnlyZeros()
        {
            GenerateArrayProducts(new[] { 0, 0, 0 }).Should().BeEquivalentTo(new[] { 0, 0, 0 }, c => c.WithStrictOrdering());
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2 }, new[] { 2, 2, 1 })]
        [InlineData(new[] { 1, 2, 1 }, new[] { 2, 1, 2 })]
        [InlineData(new[] { 2, 1, 1 }, new[] { 1, 2, 2 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 120, 60, 40, 30, 24 })]
        [InlineData(new[] { 3, 2, 1 }, new[] { 2, 3, 6 })]
        [InlineData(new[] { 0, 2, 2 }, new[] { 4, 0, 0 })]
        public void ArrayWithThreeNumbers_ShouldReturnMultipliedArray(int[] input, int[] expectedOutput)
        {
            GenerateArrayProducts(input).Should().BeEquivalentTo(expectedOutput, c => c.WithStrictOrdering());
        }

        public int[] GenerateArrayProducts(int[] input)
        {
            return arrayManipulator.GenerateArrayProducts(input);
        }
    }
}
