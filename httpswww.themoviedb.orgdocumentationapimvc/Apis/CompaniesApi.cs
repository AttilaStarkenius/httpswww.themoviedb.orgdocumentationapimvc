using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Companies;
using httpswww.themoviedb.orgdocumentationapimvc.Extensions;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Apis
{
    public class CompaniesApi : ICompaniesApi
    {
        private readonly IRequestHandler _requestHandler;
        private readonly ITmdbEasyClient _client;

        public CompaniesApi(ITmdbEasyClient client)
        {
            _client = client;
            _requestHandler = new RequestHandler(_client);
        }

        public async Task<CompanyDetails> GetDetailsAsync(int companyId, string apiKey = null)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"company/{companyId}")
                .AddApiKey(apiKey);

            return await _requestHandler.ExecuteAsync<CompanyDetails>(restRequest);
        }

        public async Task<MoviesByCompany> GetMoviesAsync(int companyId, string apiKey = null, string language = null)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"company/{companyId}")
                .AddLanguage(language)
                .AddApiKey(apiKey);

            return await _requestHandler.ExecuteAsync<MoviesByCompany>(restRequest);
        }

        public async Task<CompanyList> SearchAsync(string customQuery, string apiKey = null, int page = 1)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"search/company")
                .AddApiKey(apiKey)
                .AddCustomQuery(customQuery)
                .AddPage(page);

            return await _requestHandler.ExecuteAsync<CompanyList>(restRequest);
        }
    }
}
