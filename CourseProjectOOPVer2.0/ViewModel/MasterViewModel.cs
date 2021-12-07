using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOOPVer2._0.ViewModel
{
    public class MasterViewModel : ViewModelBase
    {
        public ICommand ShDw
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    ShutDown();
                });
            }
        }
        void ShutDown()
        {
            App.Current.Shutdown();
        }
        public ICommand Min
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Minimize();
                });
            }
        }
        void Minimize()
        {
            App.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized;
        }
        public ICommand Exit
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    Ex();
                });
            }
        }
        void Ex()
        {
            using (var fs = new FileStream(@"SavedUser/User.txt", FileMode.Truncate))
            {
            }
            App.Current.MainWindow.Hide();
            App.Current.MainWindow = new MainWindow();
            App.Current.MainWindow.Show();
        }

    }
}
