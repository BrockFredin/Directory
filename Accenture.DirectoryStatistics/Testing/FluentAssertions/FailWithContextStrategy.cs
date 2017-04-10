using System.Collections.Generic;
using FluentAssertions.Execution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Accenture.DirectoryStatistics.Testing.FluentAssertions
{
    public class FailWithContextStrategy : IAssertionStrategy
    {
        public IEnumerable<string> DiscardFailures()
        {
            return new string[] {};
        }

        public IEnumerable<string> FailureMessages
        {
            get { return new string[] {}; }
        }

        public void HandleFailure(string message)
        {
            throw new AssertFailedException(AssertContext.CurrentFullContext + message);
        }

        public void ThrowIfAny(IDictionary<string, object> context)
        {
        }
    }
}