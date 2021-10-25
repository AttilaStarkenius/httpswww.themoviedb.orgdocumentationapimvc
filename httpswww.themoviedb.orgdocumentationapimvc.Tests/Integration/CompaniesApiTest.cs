using NUnit.Framework;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.Apis;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Companies;
using httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration.TestFixtures;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration
{
    [TestFixture]
    [Category("CompaniesApi")]
    public class CompaniesApiTest : TestBase
    {
        [TestCase(1)]
        public async Task GetDetailsAsync_ValidId_ReturnsValidResult(int id)
        {
            ICompaniesApi apiUnderTest = new CompaniesApi(_clientWithNoApiKey);

            CompanyDetails details = await apiUnderTest.GetDetailsAsync(id, _userApiKey);

            Assert.IsNotNull(details);
            Assert.AreEqual(id, details.Id);
        }

        [TestCase(1)]
        public async Task GetMoviesAsync_ValidId_ReturnsValidResult(int id)
        {
            ICompaniesApi apiUnderTest = new CompaniesApi(_clientWithNoApiKey);

            MoviesByCompany details = await apiUnderTest.GetMoviesAsync(id, _userApiKey);

            Assert.IsNotNull(details);
            Assert.AreEqual(id, details.Id);
        }
    }
}
