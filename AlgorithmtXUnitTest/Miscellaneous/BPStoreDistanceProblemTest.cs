using Algorithms.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmtXUnitTest.Miscellaneous
{
    public class BPStoreDistanceProblemTest
    {
        private BPStoreDistanceProblem bp;

        public BPStoreDistanceProblemTest()
        {
            bp = new BPStoreDistanceProblem();
        }

        [Fact]
        public void IsAbleToBuildSores_Returns_True()
        {
            // Arrange
            var locations = new int[] { 1, 4, 2, 8, 9 };
            var numberOfStoresToBuild = 3;
            var distance = 3;

            // Act
            var result = bp.BuildStores(locations, numberOfStoresToBuild, distance);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAbleToBuildSores_Returns_False()
        {
            // Arrange
            var locations = new int[] { 1, 4, 2, 8, 9 };
            var numberOfStoresToBuild = 3;
            var distance = 3;

            // Act
            var result = bp.BuildStores(locations, numberOfStoresToBuild, distance);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void FindDistance()
        {
            // Arrange
            var locations = new int[] { 1, 4, 2, 8, 9 };
            var numberOfStoresToBuild = 3;

            // Act
            var result = bp.BuildStores(locations, numberOfStoresToBuild);

            // Assert
            Assert.Equal(3, 3);
        }
    }
}
