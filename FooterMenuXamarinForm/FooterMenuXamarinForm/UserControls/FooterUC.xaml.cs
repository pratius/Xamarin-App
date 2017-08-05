using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FooterMenuXamarinForm.UserControls
{
    public partial class FooterUC : ContentView
    {
        public FooterUC()
        {
            InitializeComponent();
        }

        public static BindableProperty OnConfirmCommandProperty = BindableProperty.Create(
                                                          propertyName: "MenuFirstCommand",
                                                          returnType: typeof(ICommand),
                                                          declaringType: typeof(FooterUC),
                                                          defaultValue: new Command(ExecuteOnAppearing) as ICommand,
                                                          defaultBindingMode: BindingMode.OneWay,
                                                          propertyChanged: OnConfirmCommandPropertyChanged);

        private static void OnConfirmCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (FooterUC)bindable;
            control.MenuFirst.Command = (ICommand)newValue;
        }

        public ICommand MenuFirstCommand
        {
            get { return (ICommand)base.GetValue(OnConfirmCommandProperty); }
            set { base.SetValue(OnConfirmCommandProperty, value); }
        }

        private static void ExecuteOnAppearing(object obj)
        {
            //Empty Command
        }






        public static BindableProperty OnConfirmCommandParameterProperty = BindableProperty.Create(
                                                           propertyName: "MenuFirstCommandParameter",
                                                           returnType: typeof(string),
                                                           declaringType: typeof(FooterUC),
                                                           defaultValue: string.Empty,
                                                           defaultBindingMode: BindingMode.OneWay,
                                                           propertyChanged: OnConfirmCommandParameterPropertyChanged);

        private static void OnConfirmCommandParameterPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (FooterUC)bindable;
            control.MenuFirst.CommandParameter = (string)newValue;
        }

        public string MenuFirstCommandParameter
        {
            get { return (string)base.GetValue(OnConfirmCommandParameterProperty); }
            set { base.SetValue(OnConfirmCommandParameterProperty, value); }
        }


        public static BindableProperty ButtonTextProperty = BindableProperty.Create(
                                                            propertyName: "ButtonText",
                                                            returnType: typeof(string),
                                                            declaringType: typeof(FooterUC),
                                                            defaultValue: String.Empty,
                                                            defaultBindingMode: BindingMode.OneWay,
                                                            propertyChanged: ButtonTextPropertyChanged);

        private static void ButtonTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var popup = (FooterUC)bindable;
            popup.Menu1.Text = newValue as string;
        }

        public string ButtonText
        {
            get { return (string)base.GetValue(ButtonTextProperty); }
            set { base.SetValue(ButtonTextProperty, value); }
        }
    }
}
