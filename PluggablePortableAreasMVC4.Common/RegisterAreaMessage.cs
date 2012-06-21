using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcContrib.PortableAreas;

namespace PluggablePortableAreas.Common
{
    public class RegisterAreaMessage : IEventMessage
    {
        public string LinkText { get; private set; }
        public string AreaName { get; private set; }
        public string ControllerName { get; private set; }
        public string ActionName { get; private set; }

        public RegisterAreaMessage(string linkText, string areaName, string controllerName, string actionName)
        {
            this.LinkText = linkText;
            this.AreaName = areaName;
            this.ControllerName = controllerName;
            this.ActionName = actionName;
        }

        public override string ToString()
        {
            return String.Format(@"RegisterAreaMessage, AreaName: '{0}'", AreaName);
        }
    }
}
