using System.Web;
using System.Web.Mvc;

namespace KT_VuHoangGiang_5198
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
