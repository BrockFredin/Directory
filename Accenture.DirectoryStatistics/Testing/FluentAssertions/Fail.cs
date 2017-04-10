using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Accenture.DirectoryStatistics.Testing.FluentAssertions
{
    /// <summary>
    ///     Helper methods that create assertion failures which contain the full context established by use of
    ///     <see cref="AssertContext" />.
    ///     (If you use any of the Assert.XXX() methods, you will NOT get the benefit of this context in the error message
    ///     reported.
    ///     Normally, FluentAssertions should be used to generate the assertions because this WILL use this context, but there
    ///     are certain times when
    ///     you need to generate asserts that cannot be generated with this library.
    ///     (for example, in occasions where your assert would need OR conditions, FluentAssertions does not support this)
    /// </summary>
    public static class Fail
    {
        /// <summary>
        ///     Throw an assertion failure with the provided message, as well as any context.  See <see cref="Fail" /> class notes.
        /// </summary>
        public static void With(string message)
        {
            ArgGuard.ArgumentNotNullOrEmpty(message, "message");
            throw new AssertFailedException(AssertContext.CurrentFullContext + message);
        }
    }
}