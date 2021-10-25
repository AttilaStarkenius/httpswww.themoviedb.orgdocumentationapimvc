using System.Collections.Generic;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Movies;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Television
{
    public class AlternativeTitle
    {
        public int Id { get; set; }
        public List<Titles> Results { get; set; }
    }
}
