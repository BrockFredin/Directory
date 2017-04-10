using System;
using System.Configuration;
using Accenture.DirectoryStatistics.Scenarios;
using Accenture.DirectoryStatistics.Scenarios.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Accenture.DirectoryStatistics.Core
{
	[TestClass]
	public sealed class AccentureDemo
	{
		private static readonly DirectoryStatistics<Path> directoryStatistics = new DirectoryStatistics<Path>();
		private readonly IDirectoryUserScenarios _directoryUserScenarios = new DirectoryUserScenarios(directoryStatistics);

		[TestCategory("Accenture.DirectoryStatistics.Core")]
		[TestMethod]
		public void AccentureDemoDisplayDirectoryStatistics()
		{
			int[] count = _directoryUserScenarios.DirectoryScenario(ConfigurationManager.AppSettings["Path"]);
			Console.WriteLine(string.Join(", ", count));
			Console.WriteLine("Total Number Of Files Processed, Total Number of Files That Contain Code, Total Number Of Lines Of Code");


		}
	}
}
