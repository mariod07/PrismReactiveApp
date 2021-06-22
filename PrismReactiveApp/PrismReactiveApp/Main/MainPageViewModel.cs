using DynamicData;
using DynamicData.Binding;
using MonkeyCache.FileStore;
using Newtonsoft.Json;
using Prism.Navigation;
using PrismReactiveApp.Bussines;
using PrismReactiveApp.Services;
using PrismReactiveApp.Shared;
using ReactiveUI;
using Refit;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms.Internals;

namespace PrismReactiveApp.Main
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Constants

        public HttpResponseMessage response;

        public string BaseURL = "http://www.apidashboard.somee.com";

        #endregion Constants

        #region Attributes
        private ObservableCollection<Fuel> _fuelCollection;

        #endregion Attributes

        #region Properties

        public ObservableCollection<Fuel> FuelCollection
        {
            get => _fuelCollection;
            set => this.RaiseAndSetIfChanged(ref _fuelCollection, value);
        }

       
        #endregion Properties

        #region Commands

        #endregion Commands

        #region Constructors

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Barrel.ApplicationId = "MonkeyCacheSample";
            Task.Run(() => GetResponse());

            InitializeProperties();
        }

        #endregion Constructors

        #region Methods

        public void InitializeProperties()
        {
            _fuelCollection = new ObservableCollection<Fuel>(Barrel.Current.Get<IEnumerable<Fuel>>(key: BaseURL));
        }

        async Task<IEnumerable<Fuel>> GetResponse()
        {
            var a = DateTime.Now;

            if (Connectivity.NetworkAccess != NetworkAccess.Internet && !Barrel.Current.IsExpired(key: BaseURL))
            {
                var fuels = Barrel.Current.Get<IEnumerable<Fuel>>(key: BaseURL);
                FuelCollection = new ObservableCollection<Fuel>(fuels);
                //await PopupNavigation.Instance.PushAsync(new PopUpWarning());

                var b = DateTime.Now;

                var c = b - a;
            }

           

            var apiResponse = RestService.For<IFuelsApi>(BaseURL);
            response = await apiResponse.GetFuels();

            if (response.IsSuccessStatusCode)
            {
                var JD = JsonConvert.DeserializeObject<List<Fuel>>(await response.Content.ReadAsStringAsync());
                FuelCollection = new ObservableCollection<Fuel>(JD);

                Barrel.Current.Add(key: BaseURL, data: FuelCollection, expireIn: TimeSpan.FromDays(2));
            }

           

            return null;
        }

        #endregion Methods
    }
}