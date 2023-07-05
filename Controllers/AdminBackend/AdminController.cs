//using EBike.Entity.Enum;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using EBike.Entity.Models;
//using EBike.Services.ServeicesImpl;
//using EBike.Entity.Base;
//using EBike.Utils;

//namespace EBike.Controllers.AdminBackend
//{
//    [Route("api/Backend/admin")]
//    [ApiController]
//    public class AdminController : ControllerBase
//    {
//        private readonly AdminUserService adminUserService;

//        public AdminController(AdminUserService adminUserService)
//        {
//            this.adminUserService = adminUserService;
//        }


//        [Route("login")]
//        [HttpPost]
//        public async Task<IActionResult> Login(Admin user)
//        {
//            int code = (int)ResultCode.OK;
//            string message = null;
//            Console.WriteLine("id:" + user.UserId);
//            Console.WriteLine("password:" + user.Password);
//            if(!user.Password.Equals("kel123")) { 
//                code = (int)ResultCode.ERROR;
//                message = "密码错误";
//            }
//            return new JsonResult(new { code = code, userid = user.UserId, password = user.Password,message = message });
//        }

//        [Route("register")]
//        [HttpPost]
//        public async Task<IActionResult> Regist(Admin user) {
//            if(await adminUserService.isExit(user.UserName))
//            {
//                return R.Error("用户名已存在");
//            }
//            Admin admin = adminUserService.Register(user);
//            if(admin == null)
//            {
//                return R.Error("注册失败");
//            }
//            return R.OK(user);
//        }
//    }
//}
