using CourseProjectOOPVer2._0.Logic;
using CourseProjectOOPVer2._0.Model;
using CourseProjectOOPVer2._0.Model.DB;
using CourseProjectOOPVer2._0.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CourseProjectOOPVer2._0.ViewModel
{
    class EditViewModel: ViewModelBase
    {
        private MyPageInfo page;
        private MyPageInfo pageCopy;
        private EditWindow ew;
        private Img img;
        private string wayToPic = null;
        public ICommand EdPic ///////////редактирование картинки
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    { EdWnd(); }
                });
            }
        }
        public ICommand SaveChanges
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    { Save(); }
                });
            }
        }
        public void Save()
        {
            if (wayToPic != null)
            {
                img.FileName = wayToPic.Substring(wayToPic.LastIndexOf('\\') + 1); //////краткое имя картинки ...jpg/png
                try
                {
                    img.Data = SaveAndLoadPicture.PictureToByte(wayToPic);
                }
                catch
                {
                    using(DataBaseContext db= new DataBaseContext())
                    {
                        var sql = db.Imgs.Where(x => x.Id == CurrentUser.CurrentUserID).FirstOrDefault();
                        img.Data = sql.Data;   
                    }
                }
                int count;
                using (DataBaseContext db = new DataBaseContext())
                {
                    count = db.Imgs.Count(x => x.Id == CurrentUser.CurrentUserID);
                    if (count == 0)
                    {
                        img.Id = CurrentUser.CurrentUserID;
                        db.Imgs.Add(img);
                        db.SaveChanges();
                    }
                }
                using (DataBaseContext db = new DataBaseContext())
                {
                    if (count == 1)
                    {
                        var linq = db.Imgs.Where(x => x.Id == CurrentUser.CurrentUserID).FirstOrDefault();
                        linq.Data = img.Data;
                        linq.FileName = img.FileName;
                        db.SaveChanges();
                       
                    }
                }
            }
            page = pageCopy;
            using (DataBaseContext db = new DataBaseContext())
            {
                var linq = db.PageInfo.Where(x => x.Id == CurrentUser.CurrentUserID).FirstOrDefault();
                        linq.Id = page.Id;
                        linq.Sex = page.Sex;
                        linq.BirthDay = page.BirthDay;
                        linq.City = page.City;
                        linq.Country = page.Country;
                        linq.AboutMyself = page.AboutMyself;
                ew.Close();
                db.SaveChanges();
            }
            App.Current.MainWindow.Close();
            App.Current.MainWindow = new MasterWindow();
            App.Current.MainWindow.Show();
            
        }

        public void EdWnd()
        {
            try
            {
                OpenFileDialog openwnd = new OpenFileDialog
                {
                    Filter = "Image files(*.png)|*.png|Image files(*.jpg)|*.jpg"
                };
                openwnd.ShowDialog();
                img = new Img();
                wayToPic = openwnd.FileName;
            }
            catch
            {
             return;
            }


        }
        public EditViewModel(MyPageInfo page, EditWindow ew)
        {
            this.page = page;
            this.ew = ew;
            pageCopy = new MyPageInfo(page);
        }

       
        public string Sex
        {
            get { return pageCopy.Sex; }
            set
            {
                pageCopy.Sex = value;
                OnPropertyChanged("Sex");
            }
        }
        public DateTime? BirthDay
        {
            get { return pageCopy.BirthDay; }
            set
            {
                pageCopy.BirthDay = value;
                OnPropertyChanged("BirthDay");
            }
        }
        public string Country
        {
            get { return pageCopy.Country; }
            set
            {
                pageCopy.Country = value;
                OnPropertyChanged("Country");
            }
        }
        public string City
        {
            get { return pageCopy.City; }
            set
            {
                pageCopy.City = value;
                OnPropertyChanged("City");
            }
        }
        public string AboutMyself
        {
            get { return pageCopy.AboutMyself; }
            set
            {
                pageCopy.AboutMyself = value;
                OnPropertyChanged("AboutMyself");
            }
        }
    }
}
