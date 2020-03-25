using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms_Ref.Services;
using XamarinForms_Ref.Views;

namespace XamarinForms_Ref
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
