using EBike.DBContext;
using EBike.Entity.Base;
using EBike.Entity.Models;
using EBike.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace EBike.Controllers
{
    [Route("api/testing")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly EBikeContext eBikeContext;
        public TestController(EBikeContext _eBikeContext)
        {
            eBikeContext = _eBikeContext;
        }

        [Route("user")]
        [HttpGet]
        public async Task<IActionResult> getUser()
        {
            List<User> users = eBikeContext.users.ToList();
            return R.OK(users);
        }
        [Route("mockUser")]
        [HttpGet]
        public async Task<IActionResult> mockUsers()
        {
            Random rand = new Random();
                for (int i = 0; i < 20; i++)
                {
                    User user = new User();
                    String bike = rand.Next(0, 255).ToString();
                    String name = "day" + rand.Next(0, 10);
                    user.UserName = name;
                    user.UserBindingBike = bike;
                    user.Password = HashUtils.HashStr("a pass word");
                    eBikeContext.users.Add(user);
                }
            eBikeContext.SaveChanges();
            return R.OK();
        }
        
    }
}
