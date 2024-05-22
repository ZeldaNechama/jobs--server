using Jobs_server.Models;

namespace Jobs_server.Interfaces
{
    public interface ILoginService
    {
      User GetUser(string name, string password);
    }
}
