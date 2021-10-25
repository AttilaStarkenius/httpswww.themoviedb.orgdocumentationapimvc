using System.Web;
using System.Web.Mvc;

namespace httpswww.themoviedb.orgdocumentationapimvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
