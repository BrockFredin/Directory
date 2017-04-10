using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Accenture.DirectoryStatistics.Scenarios;
using Accenture.DirectoryStatistics.Scenarios.Service;

namespace Accenture.DirectoryStatistics.UnitTests.Scenarios
{
    [TestClass]
    public class DirectoryStatisticsUserScenarioTests
    {
        [TestCategory("Accenture.DirectoryStatistics.Scenarios")]
        [TestMethod]
        public void DirectoryStatisticsUserScenarios_DoesGettingDirectoryStatisticsWork_HappyPath()
        {
            // Arrange
            var mockDirectoryStatistics = new Mock<IDirectoryStatistics<Path>>();
            var someTestImpl = new DirectoryUserScenarios(mockDirectoryStatistics.Object);

            // Act
            someTestImpl.DirectoryScenario("a");

            // Assert that sign in works
            mockDirectoryStatistics.Verify(m => m.GetTotalNumberFilesProcessed("a"), Times.Once);
            mockDirectoryStatistics.Verify(m => m.GetTotalNumberFilesContainCode("a"), Times.Once);
            mockDirectoryStatistics.Verify(m => m.GetTotalNumberLinesCode("a"), Times.Once);
        }
	}
}
