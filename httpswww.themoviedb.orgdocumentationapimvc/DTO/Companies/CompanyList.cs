using System.Collections.Generic;

namespace httpswww.themoviedb.orgdocumentationapimvc.DTO.Companies
{
    public class CompanyList
    {
        public int Page { get; set; }
        public List<Company> Results { get; set; }
        public int Total_pages { get; set; }
        public int Total_results { get; set; }
    }
}
