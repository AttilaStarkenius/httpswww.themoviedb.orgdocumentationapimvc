using System.Collections.Generic;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Images
{
    public class Images
    {
        public int Id { get; set; }
        public List<Backdrop> Backdrops { get; set; }
        public List<Poster> Posters { get; set; }
        public List<Still> Stills { get; set; }
    }
}
