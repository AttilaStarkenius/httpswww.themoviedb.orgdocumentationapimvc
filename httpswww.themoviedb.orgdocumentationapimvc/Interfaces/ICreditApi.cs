using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Other;

namespace httpswww.themoviedb.orgdocumentationapimvc.Interfaces
{
    public interface ICreditApi
    {
        /// <summary>
        /// Get movie or TV credit details by id.
        /// </summary>
        /// <param name="creditId"></param>
        /// <param name="apiKey">Optional</param>
        /// <returns></returns>
        Task<Credits> GetDetailsAsync(string creditId, string apiKey = null);
    }
}
