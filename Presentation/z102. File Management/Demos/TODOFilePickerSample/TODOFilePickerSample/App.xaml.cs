﻿using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace TODOFilePickerSample
{
    sealed partial class App : Common.BootStrapper
    {
        public App() : base()
        {
            this.InitializeComponent();
        }

        public override Task OnLaunchedAsync(ILaunchActivatedEventArgs e)
        {
            this.NavigationService.Navigate(typeof(Views.MainPage));
            return Task.FromResult<object>(null);
        }
    }
}
