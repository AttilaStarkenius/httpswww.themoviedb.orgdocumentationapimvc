using System.Collections.Generic;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Changes
{
    public class Change
    {
        public string Key { get; set; }
        public List<Item> Items { get; set; }
    }
}
