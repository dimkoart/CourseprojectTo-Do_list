using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOOPVer2._0.Model
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        [StringLength(450)]
        [Index(IsUnique = true)]
        public string Email { get; set; }
        public string Password { get; set; }

        /////////////////////Зависимость к mypageInfo
        public MyPageInfo PageInfo { get; set; }
        public List<Like> Likes { get; set; }
    }
}
