using System.Web;
using System.Web.Mvc;

namespace Zanzibar.PhotoViewr.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
