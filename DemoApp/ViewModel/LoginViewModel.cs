using System;
using System.Threading.Tasks;
using System.Windows.Input;
using DemoApp.Views;
using Xamarin.Forms;

namespace DemoApp.ViewModel
{
    public class LoginViewModel:BaseViewModel
    {
        public LoginViewModel(INavigation navigation):base(navigation)
        {
            LoginComman = new Command(async () => await ExecuteOnLogin());
        }

        public ICommand LoginComman
        {
            get;
            set;
        }

        private async Task ExecuteOnLogin()
        {
            await navigation.PushAsync(new DashboardPage());
        }
    }
}
