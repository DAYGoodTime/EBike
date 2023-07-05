using EBike.Entity.Enum;
using Microsoft.AspNetCore.Mvc;

namespace EBike.Entity.Base
{
    public class R
    {
        public ResultCode code { get; set; }
        public string message { get; set; }
        public object data { get; set; }
        public R(ResultCode code,string message,object data) {
            this.code = code;
            this.message = message;
            this.data = data;
        }

        public static JsonResult OK()
        {
            return new JsonResult(new R(ResultCode.OK, "操作成功", null));
        }
        public static JsonResult OK(object obj)
        {
            return new JsonResult(new R(ResultCode.OK, "操作成功", obj));
        }

        public static JsonResult Error(string message) {
            return new JsonResult(new R(ResultCode.ERROR, message, null));
        }
    }
}
