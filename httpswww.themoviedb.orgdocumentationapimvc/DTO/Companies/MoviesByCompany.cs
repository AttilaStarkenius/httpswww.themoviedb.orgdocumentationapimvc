using System.Collections.Generic;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Movies;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Companies
{
    public class MoviesByCompany
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public List<Movie> Results { get; set; }
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }
}
