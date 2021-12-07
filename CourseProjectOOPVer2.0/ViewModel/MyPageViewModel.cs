using CourseProjectOOPVer2._0.Logic;
using CourseProjectOOPVer2._0.Model;
using CourseProjectOOPVer2._0.Model.DB;
using CourseProjectOOPVer2._0.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace CourseProjectOOPVer2._0.ViewModel
{
    public class MyPageViewModel: ViewModelBase
    {
        public ObservableCollection<PostViewModel> PostsCollection { get; set; }
        public MyPageInfo MyPageInfo { get; set; }
        public string Name { get; set; }

        public MyPageViewModel()
        {
            PostsCollection = new ObservableCollection<PostViewModel>();
            using(DataBaseContext db = new DataBaseContext())
            {
                var u = db.Users.Where(q => q.Id == CurrentUser.CurrentUserID);
                foreach(var x in u)
                {
                    Name = x.Firstname + " " + x.Lastname;
                    break;
                }
                int linq = 0;
                linq = db.PageInfo.Count(q => q.Id == CurrentUser.CurrentUserID);
                if(linq == 0)
                {
                    MyPageInfo = new MyPageInfo() { Id = CurrentUser.CurrentUserID, BirthDay = null};
                    db.PageInfo.Add(MyPageInfo);
                    db.SaveChanges();
                    Pic =  (new ImageSourceConverter()).ConvertFromString(@"pack://application:,,,/logo1.png") as ImageSource;
                    SexVis = Visibility.Collapsed;
                    DateVis = Visibility.Collapsed;
                    CountryVis = Visibility.Collapsed;
                    CityVis = Visibility.Collapsed;
                    AboutVis = Visibility.Collapsed;
                    return;
                }
                if(linq == 1)
                {
                    var user = db.PageInfo.Where(q => q.Id == CurrentUser.CurrentUserID).FirstOrDefault();
                      MyPageInfo = user;
                    Pic = (new ImageSourceConverter()).ConvertFromString(@"pack://application:,,,/logo1.png") as ImageSource;
                    if (MyPageInfo.Sex == null || MyPageInfo.Sex == "") { SexVis = Visibility.Collapsed; }
                    if (MyPageInfo.BirthDay == null) { DateVis = Visibility.Collapsed; }
                    if (MyPageInfo.Country == null || MyPageInfo.Country == "") { CountryVis = Visibility.Collapsed; }
                    if (MyPageInfo.City == null || MyPageInfo.City == "") { CityVis = Visibility.Collapsed; }
                    if (MyPageInfo.AboutMyself == null || MyPageInfo.AboutMyself == "") { AboutVis = Visibility.Collapsed; }
                    var img = db.Imgs.Where(q => q.Id == CurrentUser.CurrentUserID);
                    {
                        foreach (var x in img)
                        {

                            if(x.Data == null)
                            {
                                Pic = (new ImageSourceConverter()).ConvertFromString(@"pack://application:,,,/logo1.png") as ImageSource;
                                return;
                            }
                            try//всем пофиг всем пофиг
                            {
                                SaveAndLoadPicture.ByteToPicture(x);
                            }
                            catch { }
                            Pic = (new ImageSourceConverter()).ConvertFromString(@"UsersPictures/" + x.Id + x.FileName) as ImageSource;
                            break;
                        }
                    }
                    var posts = db.Posts.Where(x => x.WallID == CurrentUser.CurrentUserID);
                    var sortedpost = posts.OrderByDescending(x => x.PublicDate);
                    foreach(var x in sortedpost)
                    {
                        PostsCollection.Add(new PostViewModel(x));
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Критическая ошибка базы данных");
                    App.Current.Shutdown();
                }
            }
        }
        private ImageSource Pic { get; set; }
        public ImageSource PictureSRC
        {
            get { return Pic; }
            set
            {
                Pic = value;
                OnPropertyChanged("PictureSRC");
            }
        }
        public Visibility SexVis { get; set; } = Visibility.Visible;
        public Visibility DateVis { get; set; } = Visibility.Visible;
        public Visibility CountryVis { get; set; } = Visibility.Visible;
        public Visibility CityVis { get; set; } = Visibility.Visible;
        public Visibility AboutVis { get; set; } = Visibility.Visible;
        public ICommand NewPost
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    { CreatePost(); }
                });
            }
        }
        public void CreatePost()
        {
            CreatePostView create = new CreatePostView(this);
            System.Windows.Media.Effects.BlurEffect objBlur = new System.Windows.Media.Effects.BlurEffect();
            objBlur.Radius = 4;
            App.Current.MainWindow.Effect = objBlur;
            create.ShowDialog();
            App.Current.MainWindow.Effect = null;

        }

        public ICommand Edit
        {
            get
            {
                return new DelegateCommand(() =>
                {
                     { EdWnd(); }
                });
            }
        }
        public void EdWnd()
        {
            EditWindow wnd = new EditWindow();
            wnd.DataContext = new EditViewModel(MyPageInfo, wnd);
            System.Windows.Media.Effects.BlurEffect objBlur = new System.Windows.Media.Effects.BlurEffect();
            objBlur.Radius = 4;
            App.Current.MainWindow.Effect = objBlur;
            wnd.ShowDialog();
            App.Current.MainWindow.Effect = null;

        }

        public string Sex
        {
            get { return MyPageInfo.Sex; }
            set
            {
                MyPageInfo.Sex = value;
                OnPropertyChanged("Sex");
            }
        }
        public DateTime? BirthDay
        {
            get { return MyPageInfo.BirthDay; }
            set
            {
                MyPageInfo.BirthDay = value;
                OnPropertyChanged("BirthDay");
            }
        }
        public string Country
        {
            get { return MyPageInfo.Country; }
            set
            {
                MyPageInfo.Country = value;
                OnPropertyChanged("Country");
            }
        }
        public string City
        {
            get { return MyPageInfo.City; }
            set
            {
                MyPageInfo.City = value;
                OnPropertyChanged("City");
            }
        }
        public string AboutMyself
        {
            get { return MyPageInfo.AboutMyself; }
            set
            {
                MyPageInfo.AboutMyself = value;
                OnPropertyChanged("AboutMyself");
            }
        }
    }
}
