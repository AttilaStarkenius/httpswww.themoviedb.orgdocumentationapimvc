using NUnit.Framework;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.Apis;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Changes;
using httpswww.themoviedb.orgdocumentationapimvc.Enums;
using httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration.TestFixtures;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration
{
    [TestFixture]
    [Category("ChangesApi")]
    public class ChangesApiTest : TestBase
    {
        //22.7.2021. I debug the project and get the error CS0246: Severity	Code	Description	Project	File	Line	Suppression State
        //Error CS0246  The type or namespace name 'NUnit' could not be found
        //(are you missing a using directive or an assembly reference?)	
        //httpswww.themoviedb.orgdocumentationapimvc.Tests C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc.Tests\Integration\ChangesApiTest.cs	1	Active
        //so I add NUnit nuget package to solution
        [Test]
        public async Task GetChangeListAsync_SpecificDateRange_ReturnsChangeList()
        {
            IChangesApi apiUnderTest = new ChangesApi(_clientWithNoApiKey);

            ChangeList changeList = await apiUnderTest.GetChangeListAsync(ChangeType.Movie, "26/07/2020", "25/07/2020", 1, _userApiKey);

            Assert.IsNotNull(changeList);
            Assert.IsNotEmpty(changeList.Results);
        }

        [Test]
        public async Task GetChangeListAsync_SpecificType_ReturnsChangeList()
        {
            IChangesApi apiUnderTest = new ChangesApi(_clientWithNoApiKey);

            ChangeList changeList = await apiUnderTest.GetChangeListAsync(ChangeType.TV, "26/07/2020", "25/07/2020", 1, _userApiKey);

            Assert.IsNotNull(changeList);
            Assert.IsNotEmpty(changeList.Results);
        }
    }
}
