using CourseProjectOOPVer2._0.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace CourseProjectOOPVer2._0.Logic
{
    public class SaveAndLoadPicture
    {
        private static string check = null;
        public static byte[] PictureToByte(string filename)
        {
            byte[] pic;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
            
                pic = new byte[fs.Length];
                fs.Read(pic, 0, pic.Length);
            }
            return pic;
        }
        public static void ByteToPicture(Img data)
        {
         
                if (check == null || check != "UsersPictures/" + data.Id + data.FileName)
                {
                    using (FileStream fs = new FileStream(@"UsersPictures/" + data.Id + data.FileName, FileMode.Create, FileAccess.ReadWrite))
                    {
                        fs.Write(data.Data, 0, data.Data.Length);
                        fs.Position = 0;
                    }
                }
                else { return; }
          
        }
    }
}
