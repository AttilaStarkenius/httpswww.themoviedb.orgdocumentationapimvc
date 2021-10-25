using System.Collections.Generic;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Other
{
    public class MovieCredits
    {
        public int Id { get; set; }
        public List<Cast> Cast { get; set; }
        public List<Crew> Crew { get; set; }
    }
}
