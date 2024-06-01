using Jobs_server.Interfaces;
using Jobs_server.Models;

namespace Jobs_server.Services
{
    public class LoginService : ILoginService
    {
        public static List<User> users = new List<User>() {new User(){Id=1,Name="aaa",Password="a12345678",Field=Fields.QA},
            new User(){Id=2,Name="bbb",Password="ffgky0165",Field=Fields.QA}
           
            };


        public User GetUser(string name, string password)
        {
           return users.FirstOrDefault(users => users.Name == name && users.Password == password);
        }
    }
}
