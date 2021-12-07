using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CourseProjectOOPVer2._0.Model
{
    public class MyPageInfo
    {
        [Key]
        [ForeignKey("User")]
        public long Id { get; set; }
        public string Sex { get; set; }
        public Nullable<DateTime> BirthDay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string AboutMyself { get; set; }

        ////////////////////////Внешняя зависимость от User
        public User User { get; set; }
        ///////////////////////////////////////////////////
        public Img Img { get; set; }
        //////////////////////////////////////////////////
        public List<Post> Posts { get;set; }

        public MyPageInfo()
        {
            BirthDay = new DateTime();
        }
        public MyPageInfo(MyPageInfo mpi)
        {
            BirthDay = new DateTime();
            Id = mpi.Id;
            Sex = mpi.Sex;
            BirthDay = mpi.BirthDay;
            City = mpi.City;
            Country = mpi.Country;
            AboutMyself = mpi.AboutMyself;
        
        }
    }
}
