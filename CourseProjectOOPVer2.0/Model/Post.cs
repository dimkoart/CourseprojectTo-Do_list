using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOOPVer2._0.Model
{
    public class Post
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Text { get; set; }
        [ForeignKey("MyPageInfo")]
        public long WallID { get; set; }
        public DateTime PublicDate { get; set; }
        public string UserFullName { get; set; }
        public MyPageInfo MyPageInfo { get; set; }
        public List<Like> Likes { get; set; }
    }
}
