using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TikiFake.Models;

namespace TikiFake.Repositorys
{
    public interface IUserRepository
    {
        ServiceResponses<List<User>> Get();
        ServiceResponses<User> Get(string id);
        ServiceResponses<List<User>> Create (User user);
        ServiceResponses<List<User>> Update (string id, User user);
        ServiceResponses<List<User>> Delete(string id);
    }
}
