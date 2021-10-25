using System;
using System.Collections.Generic;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Movies
{
    public class MovieReleaseDateList
    {
        public int Id { get; set; }
        public List<ReleaseDateList> Results { get; set; }
    }
}
