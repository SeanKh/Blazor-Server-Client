using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.IO;

namespace BlazorSignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //var path = @"C:\Users\Jano\Documents\tmp\data.txt";
            string path = String.Format(@"{0}\type1.txt", Directory.GetCurrentDirectory());

            //string text = "old falcon";
            File.WriteAllText(path, message);

            Console.WriteLine("text written");
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
