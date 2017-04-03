using System.Web;
using System.Web.Mvc;

namespace EMA.Disaster.Recovery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
