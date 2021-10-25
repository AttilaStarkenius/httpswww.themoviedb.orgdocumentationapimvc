using System.Threading.Tasks;
//using httpswww.themoviedb.orgdocumentationapimvc.Configurations;
using httpswww.themoviedb.orgdocumentationapimvc.Configurations;

//namespace httpswww.themoviedb.orgdocumentationapimvc.Interfaces
namespace httpswww.themoviedb.orgdocumentationapimvc.Interfaces
{
    public interface ITmdbEasyClient
    {
        TmdbEasyOptions Options { get; }

        Task<TmdbEasyModel> GetResponseAsync<TmdbEasyModel>(string query);
    }
}
