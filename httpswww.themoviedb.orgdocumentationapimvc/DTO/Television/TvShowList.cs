using System.Collections.Generic;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Television
{
    public class TvShowList
    {
        public int Page { get; set; }
        public int Total_results { get; set; }
        public int Total_pages { get; set; }
        public List<Tv> Results { get; set; }
    }
}
