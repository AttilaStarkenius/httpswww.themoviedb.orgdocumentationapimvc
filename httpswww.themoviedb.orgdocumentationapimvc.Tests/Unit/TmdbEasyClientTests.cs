using NUnit.Framework;
using System;
using httpswww.themoviedb.orgdocumentationapimvc.Configurations;

namespace httpswww.themoviedb.orgdocumentationapimvc.Tests.Unit
{
    [TestFixture]
    public class TmdbEasyClientTests
    {
        [Test]
        public void NullOptions_Throws_ArgumentNullException()
        {
            TmdbEasyOptions options = null;

            Assert.Throws<ArgumentNullException>(() => new TmdbEasyClient(options));
        }
    }
}
