using Microsoft.CST.AttackSurfaceAnalyzer.Utils;
using NUnit.Framework;

namespace Microsoft.CST.AttackSurfaceAnalyzer.Tests.Utils
{
    [TestFixture]
    public class CryptoHelpersTests
    {
        [Test]
        public void GetRandomPositiveIndex_ReturnsValidIndex()
        {
            // Arrange
            int max = 10;

            // Act
            int index = CryptoHelpers.GetRandomPositiveIndex(max);

            // Assert
            Assert.That(index, Is.GreaterThanOrEqualTo(0));
            Assert.That(index, Is.LessThan(max));
        }

        [Test]
        public void GetRandomPositiveIndex_ReturnsZeroWhenMaxIsZero()
        {
            // Arrange
            int max = 0;

            // Act
            int index = CryptoHelpers.GetRandomPositiveIndex(max);

            // Assert
            Assert.That(index, Is.EqualTo(0));
        }

        [Test]
        public void GetRandomPositiveIndex_ReturnsZeroWhenMaxIsNegative()
        {
            // Arrange
            int max = -10;

            // Act
            int index = CryptoHelpers.GetRandomPositiveIndex(max);

            // Assert
            Assert.That(index, Is.EqualTo(0));
        }
    }
}