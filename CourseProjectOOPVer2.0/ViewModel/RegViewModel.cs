﻿using CourseProjectOOPVer2._0.Model;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using CourseProjectOOPVer2._0.Model.DB;
using System.Text.RegularExpressions;

namespace CourseProjectOOPVer2._0.ViewModel
{
    public class RegViewModel : NavigateViewModel
    {
        private ICommand _pageLog; //переход на другую стр

        public ICommand Login
        {
            get
            {
                if (_pageLog == null)
                {
                    _pageLog = new RelayCommand(() =>
                    {
                        Navigate("View/LoginPage.xaml");
                    });
                }
                return _pageLog;
            }
            set { _pageLog = value; }
        }

        public User u;
        public RegViewModel()
        {
            u = new User();
        }
        public string Email
        {
            get { return u.Email; }
            set
            {
                u.Email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Firstname
        {
            get { return u.Firstname; }
            set
            {
                u.Firstname = value;
                OnPropertyChanged("Firstname");
            }
        }
        public string Lastname
        {
            get { return u.Lastname; }
            set
            {
                u.Lastname = value;
                OnPropertyChanged("Lastname");
            }
        }
        string errormessage;
        public string ErrorMessage
        {
            get { return errormessage; }
            set
            {
                errormessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }
        public ICommand CreateAccount
        {
            get
            {
                return new DelegateCommand<object>((x) =>
                {
                    if (x != null) { Create(x); }
                });
            }
        }
        public void Create(object parameter)
        {
            var values = (Password)parameter;
            var password = values.pass1 as PasswordBox;
            var passwordcopy = values.pass2 as PasswordBox;
            try { new MailAddress(Email); ErrorMessage = ""; }
            catch { ErrorMessage = "Не правильный формат электронной почты"; return; }
            using(DataBaseContext db = new DataBaseContext())
            {
                foreach(var x in db.Users)
                {
                    if (x.Email == Email) { ErrorMessage = "Пользователь с таким Email уже зарегистрирован"; return; }
                }
            }
            if (Firstname == "" || Firstname == null)
            {
                ErrorMessage = "Введите имя";
                return;
            }
            if (Lastname == "" || Lastname == null)
            {
                ErrorMessage = "Введите фамилию";
                return;
            }
            if (password.Password != passwordcopy.Password)
            {
                ErrorMessage = "Пароли не совпадают";
                return;
            }
            var rule = new Regex(@"^(?=.{8,16}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");
            if (!rule.IsMatch(password.Password))
            {
                ErrorMessage = "В пароле должны быть: цифра, буквы нижнего и верхнего \nрегистра, длина от 8 до 16 символов ";
                return;
            }
            u.Password = HashPassword.Hash(password.Password);
            using(DataBaseContext db = new DataBaseContext())
            {
                db.Users.Add(u);
                db.SaveChanges();
            }
            Login.Execute(_pageLog);
        }
    }
}
