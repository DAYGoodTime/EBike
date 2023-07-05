using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBike.Entity.Base
{

    public class BaseUser
    {
        //为什么EF不能全局设置转换规则呢？
        [Column("user_id")]
        public Guid UserId { get; set; } = Guid.NewGuid();
        [Column("password")]
        public string Password { get; set; } = string.Empty;
        [Column("user_name")]
        public string UserName { get; set; } = string.Empty;
    }
}
