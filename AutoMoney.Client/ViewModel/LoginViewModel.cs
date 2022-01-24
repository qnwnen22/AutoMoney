using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutoMoney.Client.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Account { get; set; }
        public string Password { get; set; }

        public ICommand Login { get; set; }

        public LoginViewModel()
        {
            this.Login = new RelayCommand(OnLogin);
        }
        public void OnLogin()
        {

        }
    }
}
