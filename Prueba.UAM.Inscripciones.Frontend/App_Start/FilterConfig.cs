using System.Web;
using System.Web.Mvc;

namespace Prueba.UAM.Inscripciones.Frontend
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
