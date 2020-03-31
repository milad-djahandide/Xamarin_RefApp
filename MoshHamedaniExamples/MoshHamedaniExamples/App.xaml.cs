using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoshHamedaniExamples
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Xaml_Examples.Component_Binding();
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
