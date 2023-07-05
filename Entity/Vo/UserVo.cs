using System.ComponentModel.DataAnnotations.Schema;

namespace EBike.Entity.Vo
{
    public class UserVo
    {
        public Guid UserId { get; set; } = Guid.NewGuid();
        public string UserName { get; set; } = string.Empty;
        public long VipExp { get; set; } = 0;
        public string UserAvatar { get; set; } = string.Empty;
        public string UserPhone { get; set; } = string.Empty;
        public string UserBindingBike { get; set; } = string.Empty;
        //用户类型，0默认用户，1商家
        public int UserType { get; set; } = 0;
    }
}
