using System.Collections.Generic;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Reviews
{
    public class UserReview
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public List<ReviewBase> Results { get; set; }
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }
}
