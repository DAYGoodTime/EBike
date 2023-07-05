using EBike.Entity.Models;
using System.Linq.Expressions;

namespace EBike.Services.IServices
{
    public interface IUserService
    {
        public User? Login(User user);
        public Task<bool> isExit(string name);
        public User Register(User user);
    }
}
