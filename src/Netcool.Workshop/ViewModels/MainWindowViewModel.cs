﻿using Netcool.Workshop.Views;
using ReactiveUI;
using Splat;

namespace Netcool.Workshop.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router
        {
            get;
        }
        public MainWindowViewModel()
        {
            Router = new RoutingState();

            RegisterDependencies();

            Router.Navigate.Execute(new LayoutViewModel(this));
        }

        public void RegisterDependencies()
        {
            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
            Locator.CurrentMutable.Register(() => new LayoutView(), typeof(IViewFor<LayoutViewModel>));
        }

    }
}
