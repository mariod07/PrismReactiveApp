using Prism.Events;
using Prism.Navigation;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;

namespace PrismReactiveApp.Shared
{
    public abstract class BaseViewModel: ReactiveObject
    {
        #region Properties

        public IEventAggregator EventAggregator;

        public INavigationService NavigationService;

        #endregion Properties

        #region Constructors

        public BaseViewModel()
        {
        }

        public BaseViewModel(INavigationService navigationService) : base()
        {
            NavigationService = navigationService;
        }

        public BaseViewModel(IEventAggregator eventAggregator, INavigationService navigationService) : base()
        {
            EventAggregator = eventAggregator;
            NavigationService = navigationService;
        }

        #endregion Constructors
    }
}
