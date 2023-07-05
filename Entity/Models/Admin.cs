using EBike.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBike.Entity.Models
{

    public class Admin : BaseUser
    {
        //lower is powerful
        public int Privilege { get; set; } = 0;

    }
}
