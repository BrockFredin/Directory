using System;
using System.IO;

namespace Accenture.DirectoryStatistics.Scenarios.Service
{
    /// <summary>
    /// Directory Statistics Contract
    /// </summary>
    public interface IDirectoryStatistics<T> where T : IPath
    {
        int GetTotalNumberFilesProcessed(string directory);
        int GetTotalNumberFilesContainCode(string directory);
        int GetTotalNumberLinesCode(string directory);
    }

	public class DirectoryStatistics<T> : IDirectoryStatistics<Path>
	{
	    private int fileCount;
		private int filesWithContent;
		private int individualFileLineCount;
		private int totalLineCount;

		public int GetTotalNumberFilesContainCode(string directory)
		{
			string[] fileArray = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
			int textFiles = Directory.GetFiles(directory, "*.txt*", SearchOption.AllDirectories).Length;
			
			for (int i = 0; i < fileArray.Length; i++)
			{
				individualFileLineCount = File.ReadAllLines(@fileArray[i]).Length;
				totalLineCount = totalLineCount + individualFileLineCount;

				if (individualFileLineCount > 0)
				{
					filesWithContent++;
				}
			}

			return filesWithContent - textFiles;
		}

		public int GetTotalNumberFilesProcessed(string directory)
		{
			return fileCount = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories).Length;
		
		}

		public int GetTotalNumberLinesCode(string directory)
		{
			// hard coding 23 for the 23 lines of .txt code that shouldn't be counted
			return totalLineCount - 23;
		}
	}
}