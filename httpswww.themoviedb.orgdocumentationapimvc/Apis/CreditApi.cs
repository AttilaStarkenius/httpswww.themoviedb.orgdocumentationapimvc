//using System.Data.Services;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Apis
{
    public class CreditApi : ICreditApi
    {
        private readonly IRequestHandler _requestHandler;
        //11.7.2021. private readonly IRequestHandler _requestHandler; gives error CS0104 
        //Severity	Code	Description	Project	File	Line	Suppression State
        //Error CS0104	'IRequestHandler' is an ambiguous reference between 
        //'TmdbEasy.Interfaces.IRequestHandler' and 'System.Data.Services.IRequestHandler'	
        //httpswww.themoviedb.orgdocumentationapimvc 
        //C:\Users\Attila\source\repos\httpswww.themoviedb.orgdocumentationapimvc\httpswww.themoviedb.orgdocumentationapimvc\Apis\CreditApi.cs	10	Active
        //so I comment out every "using System.Data.Services;"

        private readonly ITmdbEasyClient _client;

        public CreditApi(ITmdbEasyClient client)
        {
            _client = client;
            _requestHandler = new RequestHandler(_client);
        }

        public async Task<Credits> GetDetailsAsync(string creditId, string userApiKey = null)
        {
            var restRequest = _requestHandler
              .CreateRequest()
              .AddUrlSegment("credit")
              .AddUrlSegment(creditId)
              .AddApiKey(userApiKey);

            return await _requestHandler.ExecuteAsync<Credits>(restRequest);
        }
    }
}
