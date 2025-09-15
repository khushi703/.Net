using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex9_chatapp.Hubs
{
    public class ChatHub : Hub
    {
        private static List<string> Messages = new List<string>();

        public void SendMessage(string username, string message)
        {
            string finalMsg = $"{username}: {message}";
            Messages.Add(finalMsg);

            // send to all clients
            Clients.All.receiveMessage(finalMsg);
        }

        public List<string> GetAllMessages()
        {
            return Messages;
        }
    }
}