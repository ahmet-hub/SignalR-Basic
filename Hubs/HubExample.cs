using Microsoft.AspNetCore.SignalR;

namespace SignalR_Basic.Hubs
{
    public class HubExample : Hub
    {
        public async Task SendMessageAsync(string message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }
    }
}
