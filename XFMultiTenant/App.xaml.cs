using DryIoc;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using XFMultiTenant.Common;
using XFMultiTenant.ViewModels;

namespace XFMultiTenant
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            InitializeTenant();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        private void InitializeTenant()
        {
            ITenant tenant = Container.Resolve<ITenant>();
            Resources[Constants.PRIMARY_COLOR] = tenant.PrimaryColor;
            Resources[Constants.SECONDARY_COLOR] = tenant.SecondaryColor;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage,MainPageViewModel>();
        }
    }
}
