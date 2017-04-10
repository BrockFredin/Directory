using Accenture.DirectoryStatistics.Scenarios.Service;

namespace Accenture.DirectoryStatistics.Scenarios
{
    /// <summary>
    /// User specific scenarios
    /// </summary>
    public interface IDirectoryUserScenarios
    {
        int[] DirectoryScenario(string directory);
    }

    public class DirectoryUserScenarios : IDirectoryUserScenarios
    {
        private readonly IDirectoryStatistics<Path> _directoryStatistics;
		private int[] array = new int[3];

		public DirectoryUserScenarios(IDirectoryStatistics<Path> directoryStatistics)
        {
            _directoryStatistics = directoryStatistics;
        }

		public int[] DirectoryScenario(string directory)
        {
            array[0] = _directoryStatistics.GetTotalNumberFilesProcessed(directory);
			array[1] =_directoryStatistics.GetTotalNumberFilesContainCode(directory);
			array[2] = _directoryStatistics.GetTotalNumberLinesCode(directory);
			return array;
        }
    }
}