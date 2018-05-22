using System;

using App3.Views;
using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace App3
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
            // Handle when your app starts
            //see vist oncreate()?
            AppCenter.Start("90f41a98-c3f5-43d2-869a-fa1c80bcc02c",
                   typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
