﻿using System;
using System.Threading.Tasks;
using TODOSQLiteSample.Services.SQLiteService;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;

namespace TODOSQLiteSample
{
    sealed partial class App : Common.BootStrapper
    {
        public App() : base()
        {
            this.InitializeComponent();
        }

        public override Task OnLaunchedAsync(ILaunchActivatedEventArgs e)
        {
            // Load the database
            SQLiteService.LoadDatabase();

            this.NavigationService.Navigate(typeof(Views.MainPage));

            return Task.FromResult<object>(null);
        }

        protected async override Task OnSuspendingAsync(object s, SuspendingEventArgs e)
        {
            // Dirty hack until I can figure out how to fix OnNavigatedFrom behaviour
            var deferral = e.SuspendingOperation.GetDeferral();
            // Give enough time for the file storage to work when app is suspending
            await Task.Delay(500);
            deferral.Complete();
        }
    }
}
