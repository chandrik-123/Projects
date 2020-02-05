using System.Web;
using System.Web.Mvc;

namespace IT_BCP_POA_MVC_V1._0
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
