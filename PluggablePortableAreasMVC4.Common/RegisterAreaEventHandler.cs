using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcContrib.PortableAreas;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace PluggablePortableAreas.Common
{

    public class RegisterAreaEventHandler : MessageHandler<RegisterAreaMessage>
    {
        public static ConcurrentBag<RegisterAreaMessage> RegisteredAreas = new ConcurrentBag<RegisterAreaMessage>();

        public override void Handle(RegisterAreaMessage message)
        {
            Trace.WriteLine(String.Format("Handling message from '{0}'...", message.AreaName));
            RegisteredAreas.Add(message);
        }
    }
}
