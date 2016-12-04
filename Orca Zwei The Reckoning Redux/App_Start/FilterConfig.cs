using System.Web;
using System.Web.Mvc;

namespace Orca_Zwei_The_Reckoning_Redux
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
