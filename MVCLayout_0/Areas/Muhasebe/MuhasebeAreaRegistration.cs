using System.Web.Mvc;

namespace MVCLayout_0.Areas.Muhasebe
{
    public class MuhasebeAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Muhasebe";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Muhasebe_default",
                "Muhasebe/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}