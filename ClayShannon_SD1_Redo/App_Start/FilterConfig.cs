using System.Web;
using System.Web.Mvc;

namespace ClayShannon_SD1_Redo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
