using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MoveShape.Hubs
{
    public class ShapeHub : Hub
    {
        //前端调这个MoveShape
        public async Task MoveShape(int x , int y)
        {
            //后端调前端shapeMoved 更新渲染
            await Clients.Others.SendAsync("shapeMoved", x, y);
        }
    }
}
