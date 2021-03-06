//using System.Data.Services;
using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Reviews;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

namespace httpswww.themoviedb.orgdocumentationapimvc.Apis
{
    public class ReviewApi : IReviewApi
    {
        private readonly IRequestHandler _requestHandler;
        private readonly ITmdbEasyClient _client;

        public ReviewApi(ITmdbEasyClient client)
        {
            _client = client;
            _requestHandler = new RequestHandler(_client);
        }

        public async Task<Review> GetReviewDetailsAsync(string reviewId, string apiKey = null)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"review/{reviewId}")
                .AddApiKey(apiKey);

            return await _requestHandler.ExecuteAsync<Review>(restRequest);
        }
    }
}
