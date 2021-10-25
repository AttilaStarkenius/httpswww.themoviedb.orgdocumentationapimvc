using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Images;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;
//using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Apis
{
    public class CollectionApi : ICollectionApi
    //22.7.2021. when I debug the project public class CollectionApi : ICollectionApi
    //gives me the error CS0738: Severity	Code	Description	Project	File	Line	Suppression State
    //Error   CS0738	'CollectionApi' does not implement interface member
    //'ICollectionApi.GetDetailsAsync(int, string, string)'.
    //'CollectionApi.GetDetailsAsync(int, string, string)' cannot
    //implement 'ICollectionApi.GetDetailsAsync(int, string, string)' because
    //it does not have the matching return type of 'Task<Collections>'.	httpswww.themoviedb.orgdocumentationapimvc C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Apis\CollectionApi.cs	9	Active
    //so I uncomment these lines: //using httpswww.themoviedb.orgdocumentationapimvc.DTO.Images;
    //using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;
    //using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;
    {
        private readonly IRequestHandler _requestHandler;
        private readonly ITmdbEasyClient _client;

        public CollectionApi(ITmdbEasyClient client)
        {
            _client = client;
            _requestHandler = new RequestHandler(_client);
        }

        public async Task<Collections> GetDetailsAsync(int collectionId, string apiKey = null, string language = null)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"collection/{collectionId}")
                .AddLanguage(language)
                .AddApiKey(apiKey);

            return await _requestHandler.ExecuteAsync<Collections>(restRequest);
        }

        public async Task<Images> GetImagesAsync(int collectionId, string apiKey = null, string language = null)
        {
            var restRequest = _requestHandler
               .CreateRequest()
               .AddUrlSegment($"collection/{collectionId}")
               .AddUrlSegment($"images")
               .AddLanguage(language)
               .AddApiKey(apiKey);

            return await _requestHandler.ExecuteAsync<Images>(restRequest);
        }
    }
}
