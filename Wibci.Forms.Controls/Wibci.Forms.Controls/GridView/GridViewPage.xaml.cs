using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wibci.Forms.Controls.GridView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridViewPage : ContentPage
    {
        private GridViewViewModel _viewModel;

        public GridViewPage()
        {
            InitializeComponent();
            _viewModel = new GridViewViewModel();
            BindingContext = _viewModel; ;
            Title = "GridView";
        }

        protected override void OnAppearing()
        {
            _viewModel.LoadData();
        }
    }
}
