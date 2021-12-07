using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOOPVer2._0.Model
{
    public class Img
    {
        [Key]
        [ForeignKey("MyPageInfo")]
        public long Id { get; set; }
        public string FileName { get; set; }
        public byte[] Data { get;  set; }

        public MyPageInfo MyPageInfo { get; set; }

        public Img(string filename, byte[] data)
        {
            FileName = filename;
            Data = data;
        }
        public Img()
        {
    
        }

    }
}
