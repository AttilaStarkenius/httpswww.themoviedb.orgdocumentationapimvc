using System;
using System.Collections.Generic;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Movies
{
    public class ReleaseDateList
    {
        public string Iso_3166_1 { get; set; }
        public List<ReleaseDate> Release_dates { get; set; }
    }
}
