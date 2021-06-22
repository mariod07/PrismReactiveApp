using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismReactiveApp.Main;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismReactiveApp
{
    public partial class App : PrismApplication
    {
        #region Constructor
        
        public App(IPlatformInitializer initializer) : base(initializer)
        {
        }

        #endregion Constructor

        protected override async void OnInitialized()
        {
            new AppBootstrapper();

            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage").ConfigureAwait(false);
        }

        protected override void OnResume()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnStart()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage,MainPageViewModel>();
        }
    }
}
