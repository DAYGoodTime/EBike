using EBike.DBContext;
using EBike.Entity.Models;
using EBike.Services.IServices;
using EBike.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EBike.Services.ServicesImp
{
    public class UserService : IUserService
    {
        private readonly EBikeContext eBikeContext;
        public UserService(EBikeContext _eBikeContext)
        {
            eBikeContext = _eBikeContext;
        }

        public User? Login(User user)
        {
            User reuslt = this.Select(x=>x.UserName == user.UserName);
            if(reuslt == null)
            {
                return null;
            }
            else
            {
                if(HashUtils.HashStr(user.Password) == reuslt.Password) {
                    return reuslt;
                }
                else
                {
                    return null;
                }
            }
        }
        public async Task<User> SelectSync(Expression<Func<User, bool>> where)
        {
            return await eBikeContext.users.Where(where).FirstAsync();
        }
        public User Select(Expression<Func<User, bool>> where)
        {
            return eBikeContext.users.Where(where).First();
        }

        public async Task<bool> isExit(string name)
        {
            User user = await this.SelectSync(x => x.UserName == name);
            return user != null;
        }

        public User Register(User user)
        {
            user.Password = HashUtils.HashStr(user.Password);
            eBikeContext.users.Add(user);
            eBikeContext.SaveChanges();
            return user;
        }
    }
}
