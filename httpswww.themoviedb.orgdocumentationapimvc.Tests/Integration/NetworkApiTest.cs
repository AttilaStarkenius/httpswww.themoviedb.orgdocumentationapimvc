using NUnit.Framework;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.Apis;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;
using httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration.TestFixtures;

namespace httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration
{
    [Category("NetworkApi")]
    internal class NetworkApiTest : TestBase
    {       
        [TestCase(213)]
        public async Task GetDetailsAsync_ValidId_CustomApiKey_ReturnsValidResult(int id)
        {
            INetworksApi apiUnderTest = new NetworksApi(_clientWithNoApiKey);

            Network result = await apiUnderTest.GetDetailsAsync(id, _userApiKey);

            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
        }

        [TestCase(213)]
        public async Task GetDetailsAsync_ValidId_DefaultApiKey_ReturnsValidResult(int id)
        {
            INetworksApi apiUnderTest = new NetworksApi(_clientWithApiKey);

            Network result = await apiUnderTest.GetDetailsAsync(id);

            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.Id);
        }
    }
}
