//using System.Data.Services;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

//namespace httpswww.themoviedb.orgdocumentationapimvc.Apis
namespace httpswww.themoviedb.orgdocumentationapimvc.Apis

{
    public class NetworksApi : INetworksApi
    {
        private readonly IRequestHandler _requestHandler;
        private readonly ITmdbEasyClient _client;

        public NetworksApi(ITmdbEasyClient client)
        {
            _client = client;
            _requestHandler = new RequestHandler(_client);
            //14.7.2021. _requestHandler = new RequestHandler(_client); gives me error CSO266:
            //Severity	Code	Description	Project	File	Line	Suppression State
            //Error CS0266  Cannot implicitly convert type 'TmdbEasy.RequestHandler' to 
            //'TmdbEasy.Interfaces.IRequestHandler'.An explicit conversion exists 
            //(are you missing a cast?)  httpswww.themoviedb.orgdocumentationapimvc C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Apis\ReviewApi.cs	16	Active
            //so I add RequestHandler file

    }

    public async Task<Network> GetDetailsAsync(int networkId, string userApiKey)
        {
            var restRequest = _requestHandler
             .CreateRequest()
             .AddUrlSegment("network")
             .AddUrlSegment($"{networkId}")
             .AddApiKey(userApiKey);

            return await _requestHandler.ExecuteAsync<Network>(restRequest);
        }
    }
}
