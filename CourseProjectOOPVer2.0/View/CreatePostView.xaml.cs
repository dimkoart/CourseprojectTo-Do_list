﻿using CourseProjectOOPVer2._0.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseProjectOOPVer2._0.View
{
    /// <summary>
    /// Логика взаимодействия для CreatePostView.xaml
    /// </summary>
    public partial class CreatePostView : Window
    {
        public CreatePostView(MyPageViewModel mypage)
        {
            InitializeComponent();
            DataContext = new CreatePostViewModel(mypage, this);
        }
    }
}
