using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcContrib.PortableAreas;
using System.Diagnostics;

namespace PluggablePortableAreas.Common
{
    public class LogAllMessagesObserver : MessageHandler<IEventMessage>
    {
        public override void Handle(IEventMessage message)
        {
            Debug.WriteLine(message, "LogAllMessagesObserver");
        }

        public override bool CanHandle(Type type)
        {
            return true;
        }
    }
}
