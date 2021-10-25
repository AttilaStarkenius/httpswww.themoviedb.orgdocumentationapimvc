using System.Threading.Tasks;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Reviews;

namespace httpswww.themoviedb.orgdocumentationapimvc.Interfaces
{
    public interface IReviewApi
    {
        /// <summary>
        /// Get review details by Id
        /// </summary>
        /// <param name="reviewId"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        Task<Review> GetReviewDetailsAsync(string reviewId, string apiKey = null);
    }
}
