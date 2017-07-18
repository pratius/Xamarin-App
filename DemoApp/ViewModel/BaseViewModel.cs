using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace DemoApp.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
		protected INavigation navigation;
        public BaseViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertiesChanged([CallerMemberName]string propertiesName = "")
        {
            var handler = PropertyChanged;
            if (handler == null)
                return;
            handler(this, new PropertyChangedEventArgs(propertiesName));
        }
    }
}
