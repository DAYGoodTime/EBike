//using EBike.DBContext;
//using EBike.Entity.Models;
//using EBike.Services.IServices;
//using EBike.Utils;
//using Microsoft.EntityFrameworkCore;
//using System.Linq.Expressions;

//namespace EBike.Services.ServeicesImpl
//{
//    public class AdminUserService : IAdminUserServerice
//    {
//        private readonly EBikeContext eBikeContext;
//        public AdminUserService(EBikeContext _eBikeContext)
//        {
//            eBikeContext = _eBikeContext;
//        }

//        public bool Login(Admin admin)
//        {
//            return true;
//        }
//        public async Task<Admin> Select(Expression<Func<Admin, bool>> where)
//        {
//            return await eBikeContext.adminUsers.Where(where).FirstAsync();
//        }

//        public async Task<bool> isExit(string name) {
//            Admin admin = await this.Select(x => x.UserName == name);
//            return admin != null;
//        }

//        public Admin Register(Admin admin)
//        {
//            admin.Password = HashUtils.HashStr(admin.Password);
//            eBikeContext.adminUsers.Add(admin);
//            eBikeContext.SaveChanges();
//            return admin;
//        }
//    }
//}
