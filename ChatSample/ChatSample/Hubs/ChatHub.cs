using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatSample.Hubs
{
    public class ChatHub : Hub
    {
        public async Task Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            /*SendAsync(string method, object arg1, object arg2) => 这里的Methon是前端的方法，这是类似rpc远程调用*/
            await Clients.All.SendAsync("broadcastMessage", name, message);
        }
    }
}