using EBike.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBike.Entity.Models
{
    [Table("users")]
    public class User : BaseUser
    {
        [Column("vip_exp")]
        public long VipExp { get; set; } = 0;
        [Column("user_avatar")]
        public string UserAvatar { get; set; } = string.Empty;
        [Column("user_phone")]
        public string UserPhone { get; set; } = string.Empty;
        [Column("user_binding_bike")]
        public string UserBindingBike { get; set; } = string.Empty;

        //用户类型，0默认用户，1商家
        [Column("user_type")]
        public int UserType { get; set; } = 0;
    }
}
