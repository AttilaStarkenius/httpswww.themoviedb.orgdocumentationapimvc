using System.Collections.Generic;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Configuration;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Apis
{
    public class ConfigApi : IConfigApi
    {
        private readonly IRequestHandler _requestHandler;
        private readonly ITmdbEasyClient _client;

        public ConfigApi(ITmdbEasyClient client)
        {
            _client = client;
            _requestHandler = new RequestHandler(_client);
        }

        public async Task<Configuration> GetConfigurationAsync(string userApiKey = null)
        {
            var restRequest = _requestHandler
               .CreateRequest()
               .AddUrlSegment("configuration")
               .AddApiKey(userApiKey);

            return await _requestHandler.ExecuteAsync<Configuration>(restRequest);
        }

        public async Task<List<Country>> GetCountriesAsync(string userApiKey = null)
        {
            var restRequest = _requestHandler
               .CreateRequest()
               .AddUrlSegment("configuration/countries")
               .AddApiKey(userApiKey);

            return await _requestHandler.ExecuteAsync<List<Country>>(restRequest);
        }

        public async Task<List<JobsByDepartment>> GetJobsAsync(string userApiKey = null)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment("configuration/jobs")
                .AddApiKey(userApiKey);

            return await _requestHandler.ExecuteAsync<List<JobsByDepartment>>(restRequest);
        }

        public async Task<List<Language>> GetLanguagesAsync(string userApiKey = null)
        {
            var restRequest = _requestHandler
                 .CreateRequest()
                 .AddUrlSegment("configuration/languages")
                 .AddApiKey(userApiKey);

            return await _requestHandler.ExecuteAsync<List<Language>>(restRequest);
        }

        public async Task<List<TimeZones>> GetTimeZonesAsync(string userApiKey = null)
        {
            var restRequest = _requestHandler
                 .CreateRequest()
                 .AddUrlSegment("configuration/timezones")
                 .AddApiKey(userApiKey);

            return await _requestHandler.ExecuteAsync<List<TimeZones>>(restRequest);
        }
    }
}
