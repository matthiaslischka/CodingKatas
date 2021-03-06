﻿using FluentAssertions;
using Xunit;

namespace PancakeSort
{
    public class SorterTests
    {
        [Fact]
        public void EmptyArray_ShouldReturnEmptyArray()
        {
            AssertSort(new int[0], new int[0]);
        }

        [Fact]
        public void SortedArray_ShouldReturnUnchanged()
        {
            AssertSort(new[] { 1, 2, 3 }, new[] { 1, 2, 3 });
        }

        [Fact]
        public void UnsortedTwoElementsArray_ShouldReturnSorted()
        {
            AssertSort(new[] { 2, 1 }, new[] { 1, 2 });
        }

        [Theory]
        [InlineData(new[] { 2, 1, 3 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
        [InlineData(new[] { 5, 8, 1, 9, 4, 3, 2, 6, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [InlineData(new[] { 1, 7, 6, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        public void Sort_ShouldReturnSorted(int[] arr, int[] expectedArray)
        {
            AssertSort(arr, expectedArray);
        }

        private void AssertSort(int[] arr, int[] expectedArray)
        {
            var actualResultSortFromBackToFront = new Sorter().SortFromBackToFront(arr);
            var actualResultSortWithMax = new Sorter().SortWithMax(arr);


            actualResultSortFromBackToFront.Should().BeEquivalentTo(expectedArray, c => c.WithStrictOrdering());
            actualResultSortWithMax.Should().BeEquivalentTo(expectedArray, c => c.WithStrictOrdering());
        }
    }
}