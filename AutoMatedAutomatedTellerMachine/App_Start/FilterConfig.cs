using System.Web;
using System.Web.Mvc;
using AutoMatedAutomatedTellerMachine.CustomAttributes;
namespace AutoMatedAutomatedTellerMachine
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new MyLogginnigFilterAtributte());
        }
    }

    
}
