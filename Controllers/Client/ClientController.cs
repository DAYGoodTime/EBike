using EBike.Entity.Base;
using EBike.Entity.Models;
using EBike.Entity.Vo;
using EBike.Services.IServices;
using EBike.Services.ServicesImp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace EBike.Controllers.Client
{
    [Route("api/user")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IUserService userService;

        public ClientController(IUserService userService)
        {
            this.userService = userService;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult userLogin([FromBody] User user)
        {
            User? res = userService.Login(user);
            if (res!=null)
            {
                UserVo? userVo = new UserVo().InjectFrom(user) as UserVo;
                if(userVo == null)
                {
                    return R.Error("对象转换出错!");
                }
                return R.OK(userVo);
            }
            else
            {
                return R.Error("账号或密码错误");
            }
        }
        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> userRegister([FromBody] User user)
        {
            bool isExit = await userService.isExit(user.UserName);
            if (isExit)
            {
                return R.Error("存在相同的用户名!");
            }
            return R.OK(new UserVo().InjectFrom(userService.Register(user)));
        }

    }
}
