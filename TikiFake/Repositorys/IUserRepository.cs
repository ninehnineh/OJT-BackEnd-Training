using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TikiFake.Models;

namespace TikiFake.Repositorys
{
    public interface IUserRepository
    {
        Task<ServiceResponses<List<User>>> Get();
        Task<ServiceResponses<User>> Get(string id);
        Task<ServiceResponses<List<User>>> Create (User user);
        Task<ServiceResponses<List<User>>> Update (string id, User user);
        Task<ServiceResponses<List<User>>> Delete(string id);
    }
}
