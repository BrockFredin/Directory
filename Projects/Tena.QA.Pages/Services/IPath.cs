using System;

namespace Accenture.DirectoryStatistics.Scenarios
{
    public interface IPath
    {
        void IsDirectoryPresent();
    }

    public class Path : IPath
    {
        public void IsDirectoryPresent()
        {
            throw new NotImplementedException();
        }
    }
}