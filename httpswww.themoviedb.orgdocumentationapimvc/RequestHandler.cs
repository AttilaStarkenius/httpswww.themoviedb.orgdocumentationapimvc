using System;
//using System.Data.Services;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
//using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;
using httpswww.themoviedb.orgdocumentationapimvc.Interfaces;

//[assembly: InternalsVisibleTo("httpswww.themoviedb.orgdocumentationapimvc.Tests.Unit")]
[assembly: InternalsVisibleTo("httpswww.themoviedb.orgdocumentationapimvc.Tests.Unit")]
//10.7.2021. I notice there is also TmdbEasy.Tests.Unit so I add httpswww.themoviedb.orgdocumentationapimvc.Tests
//with it to practice unit testing also and obviously change every "namespace httpswww.themoviedb.orgdocumentationapimvc"
//to "namespace httpswww.themoviedb.orgdocumentationapimvc.Tests" and every
//[assembly: InternalsVisibleTo("httpswww.themoviedb.orgdocumentationapimvc.Tests.Unit")] to
//[assembly: InternalsVisibleTo("httpswww.themoviedb.orgdocumentationapimvc.Tests.Unit")]
//and every using httpswww.themoviedb.orgdocumentationapimvc.. to httpswww.themoviedb.orgdocumentationapimvc
//because my project's name is httpswww.themoviedb.orgdocumentationapimvc, not TmdbEasy
//I will push CTRL+F and replace every TmdbEasy with httpswww.themoviedb.orgdocumentationapimvc

//namespace httpswww.themoviedb.orgdocumentationapimvc
namespace httpswww.themoviedb.orgdocumentationapimvc
{
    internal class RequestHandler : IRequestHandler
    {
        private readonly ITmdbEasyClient _client;

        public RequestHandler(ITmdbEasyClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public Request CreateRequest()
        {
            return new Request(_client.Options);
        }

        public async Task<TmdbEasyModel> ExecuteAsync<TmdbEasyModel>(Request request)
        {
            return await _client.GetResponseAsync<TmdbEasyModel>(request.GetUri()).ConfigureAwait(false);
        }
    }
}
