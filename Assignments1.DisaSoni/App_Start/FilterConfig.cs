using System.Web;
using System.Web.Mvc;

namespace Assignments1.DisaSoni
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
