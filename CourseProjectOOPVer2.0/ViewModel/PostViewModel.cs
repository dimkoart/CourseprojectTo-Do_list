using CourseProjectOOPVer2._0.Model;
using CourseProjectOOPVer2._0.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace CourseProjectOOPVer2._0.ViewModel
{
    public class PostViewModel: ViewModelBase
    {
        public Post Post { get; set; }
        public string Text { get; set; } //текст поста
        public string UserFullName { get; set; }// полное имя пользователя
        public DateTime PublicDate { get; set; }//дата публикации
        private int LikesCount { get; set; }
        public int LikesNumber ///кол-во лайков
        {
            get { return LikesCount; }
            set
            {
                LikesCount = value;
                OnPropertyChanged("LikesNumber");
            }
        }
        private ImageSource Img { get; set; }
        int IsLike;
        public ImageSource LikeStatus ///сердечко
        {
            get { return Img; }
            set
            {
                Img = value;
                OnPropertyChanged("LikeStatus");
            }
        }
        public PostViewModel(Post Post)
        {
            this.Post = Post;
            Text = Post.Text;
            UserFullName = Post.UserFullName;
            PublicDate = Post.PublicDate;
            CheckAlike();
        }
        public ICommand Like
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    { SetLike(); }
                });
            }
        }
        void CheckAlike()
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                LikesNumber = db.Likes.Count(x => x.Post_ID == Post.Id);
                IsLike = db.Likes.Count(x => x.Post_ID == Post.Id && x.User_ID == CurrentUser.CurrentUserID);
                if (IsLike == 0)
                {
                    LikeStatus = (new ImageSourceConverter()).ConvertFromString(@"pack://application:,,,/styles/IcnsPic/Like.png") as ImageSource;
                    return;
                }
                if (IsLike == 1)
                {
                    LikeStatus = (new ImageSourceConverter()).ConvertFromString(@"pack://application:,,,/styles/IcnsPic/LikeBlack.png") as ImageSource;
                    return;
                }
                else { MessageBox.Show("Проблема с бд..."); }
            }
        }
        public void SetLike()
        {
            if(IsLike == 0)
            {
                using(DataBaseContext db = new DataBaseContext())
                {
                    db.Likes.Add(new Like() { Post_ID = Post.Id, User_ID = CurrentUser.CurrentUserID });
                    db.SaveChanges();
                }
                LikeStatus = (new ImageSourceConverter()).ConvertFromString(@"pack://application:,,,/styles/IcnsPic/LikeBlack.png") as ImageSource;
                IsLike = 1;
                LikesNumber += 1;
                return;
            }
            if(IsLike == 1)
            {
                using(DataBaseContext db = new DataBaseContext())
                {
                    var like = db.Likes.Where(x => x.Post_ID == Post.Id && x.User_ID == CurrentUser.CurrentUserID).FirstOrDefault();
                    db.Likes.Remove(like);
                    db.SaveChanges();
                }
                LikeStatus = (new ImageSourceConverter()).ConvertFromString(@"pack://application:,,,/styles/IcnsPic/Like.png") as ImageSource;
                IsLike = 0;
                LikesNumber -= 1;
                return;
            }
        }
    }
}
