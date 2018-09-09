using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace TransmitDate_001
{

    /*
     * NUGET: install-package Microsoft.aspnet.signalr
     */

    public class MyHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void BroadCastServerTime()
        {
            Clients.All.DateReciever(DateTime.Now);
        }

        public void BroadCastServerMessage(string message)
        {
            Clients.All.MessageReciever(message);
        }
    }
}