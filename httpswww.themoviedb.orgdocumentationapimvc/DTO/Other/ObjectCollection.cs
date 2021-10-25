using System.Collections.Generic;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Movies;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.Television;
using httpswww.themoviedb.orgdocumentationapimvc.DTO.TV;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Other
{
    public class ObjectCollection
    {
            public List<Movie> Movie_results { get; set; }
            public List<Person> Person_results { get; set; }
            public List<Tv> Tv_results { get; set; }
            public List<Episode> Tv_episode_results { get; set; }
            public List<TvSeason> Tv_season_results { get; set; }
    }
}
