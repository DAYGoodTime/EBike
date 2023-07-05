using EBike.DBContext;
using EBike.Entity.Models;

namespace EBike.Services.IServices
{
    public interface IAdminUserServerice
    {
        bool Login(Admin admin);
        Admin Register(Admin admin);
    }
}
