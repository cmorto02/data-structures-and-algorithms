using System;
using Xunit;
using static BinarySearchAlgorithm.Program;

namespace BinarySearchTesting
{
    public class UnitTest1
    {
        [Fact]
        public void MySearchReturnsTheIndex()
        {
            int[] mockArray = new int[20] { 1, 2, 4, 9, 12, 14, 15, 18, 23, 34, 45, 56, 67, 78, 89, 90, 123, 234, 345, 456 };
            int mockKey = 90;

            int result = BinarySearch(mockArray, mockKey);

            Assert.Equal(15, result);
        }
        [Fact]
        public void MySearchReturnsNegativeOneForANumberNotFound()
        {
            int[] mockArray = new int[20] { 1, 2, 4, 9, 12, 14, 15, 18, 23, 34, 45, 56, 67, 78, 89, 90, 123, 234, 345, 456 };
            int mockKey = 16;

            int result = BinarySearch(mockArray, mockKey);

            Assert.Equal(-1, result);
        }
    }
}
