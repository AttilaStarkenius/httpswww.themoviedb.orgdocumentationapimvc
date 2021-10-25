using NUnit.Framework;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.Apis;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Images;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;
using httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration.TestFixtures;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Tests.Integration
{
    [TestFixture]
    [Category("CollectionApi")]
    public class CollectionApiTest : TestBase
    {
        [TestCase(10)]
        public async Task GetDetailsAsync_ValidId_ReturnsValidResult(int id)
        {   
            ICollectionApi apiUnderTest = new CollectionApi(_clientWithNoApiKey);

            Collections collections = await apiUnderTest.GetDetailsAsync(id, _userApiKey);

            Assert.IsNotNull(collections);
            Assert.AreEqual(id, collections.Id);
            Assert.IsNotEmpty(collections.Parts);
        }

        [TestCase(10)]
        public async Task GetImagesAsync_ValidId_ReturnsValidResult(int id)
        {
            ICollectionApi apiUnderTest = new CollectionApi(_clientWithNoApiKey);

            Images images= await apiUnderTest.GetImagesAsync(id, _userApiKey);

            Assert.IsNotNull(images);
            Assert.AreEqual(id, images.Id);
            Assert.IsNotEmpty(images.Posters);
            Assert.IsNull(images.Stills);
            Assert.IsNotEmpty(images.Backdrops);
        }
    }
}
