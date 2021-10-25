using NUnit.Framework;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.Apis;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;
using httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration.TestFixtures;

namespace httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration
{
    [Category("CreditApi")]
    internal class CreditApiTest : TestBase
    {
        [TestCase("52542282760ee313280017f9")]
        public async Task GetDetailsAsync_ValidId_CustomApiKey_ReturnsValidResult(string id)
        {
            ICreditApi apiUnderTest = new CreditApi(_clientWithNoApiKey);

            Credits details = await apiUnderTest.GetDetailsAsync(id, _userApiKey);

            Assert.IsNotNull(details);
            Assert.AreEqual(id, details.Id);
        }

        [TestCase("52542282760ee313280017f9")]
        public async Task GetDetailsAsync_ValidId_DefaultApiKey_ReturnsValidResult(string id)
        {
            ICreditApi apiUnderTest = new CreditApi(_clientWithApiKey);

            Credits details = await apiUnderTest.GetDetailsAsync(id);

            Assert.IsNotNull(details);
            Assert.AreEqual(id, details.Id);
        }
    }
}
