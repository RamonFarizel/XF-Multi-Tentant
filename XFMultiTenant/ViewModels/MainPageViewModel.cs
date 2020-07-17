using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Essentials;
using XFMultiTenant.Common;

namespace XFMultiTenant.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ITenant tenant;

        public MainPageViewModel(INavigationService navigationService, ITenant tenant)
            : base(navigationService)
        {
            Title = "Main Page";
            this.tenant = tenant;

            GoCommand = new DelegateCommand(GoClick);
        }

        private void GoClick()
        {
            Launcher.OpenAsync(new Uri(tenant.Url));
        }

        public string Tenant => tenant.Name;
        public ICommand GoCommand { get; }
    }
}