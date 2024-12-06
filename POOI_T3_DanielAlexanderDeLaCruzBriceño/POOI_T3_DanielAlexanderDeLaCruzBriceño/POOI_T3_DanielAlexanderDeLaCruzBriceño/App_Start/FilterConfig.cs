using System.Web;
using System.Web.Mvc;

namespace POOI_T3_DanielAlexanderDeLaCruzBriceño
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
