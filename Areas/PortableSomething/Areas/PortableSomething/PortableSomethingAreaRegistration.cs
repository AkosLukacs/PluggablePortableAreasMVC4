using System.Web.Mvc;
using MvcContrib.PortableAreas;
using PluggablePortableAreas.Common;

namespace PortableSomething.Areas.PortableSomething
{
    public class PortableSomethingAreaRegistration : PortableAreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "PortableSomething";
            }
        }
        public string DefaultController { get { return "Portable"; } }
        public string DefaultAction { get { return "Index"; } }

        public override void RegisterArea(AreaRegistrationContext context, IApplicationBus bus)
        {
            bus.Send(new RegisterAreaMessage("Link to the Demo area", AreaName, DefaultController, DefaultAction));

            RegisterRoutes(context);
            RegisterAreaEmbeddedResources();
        }

        private void RegisterRoutes(AreaRegistrationContext context)
        {
            context.MapRoute(
              AreaName + "_Content",
              base.AreaRoutePrefix + "/Content/{resourceName}",
              new { controller = "EmbeddedResource", action = "Index", resourcePath = "Content" },
              new[] { "MvcContrib.PortableAreas" }
          );

            context.MapRoute(
                AreaName + "_default",
                AreaName + "/{controller}/{action}/{id}",
                new { action = DefaultAction, id = UrlParameter.Optional }
            );
        }
    }

    //public class PortableSomethingAreaRegistration : AreaRegistration
    //{
    //    public override string AreaName
    //    {
    //        get
    //        {
    //            return "PortableSomething";
    //        }
    //    }

    //    public override void RegisterArea(AreaRegistrationContext context)
    //    {
    //        context.MapRoute(
    //            "PortableSomething_default",
    //            "PortableSomething/{controller}/{action}/{id}",
    //            new { action = "Index", id = UrlParameter.Optional }
    //        );
    //    }
    //}
}
