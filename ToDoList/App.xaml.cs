using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace ToDoList
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MyNavigation(new ToDoListPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			// Start Mobile Center Analytics & Mobile Center Crashes services
			MobileCenter.Start(typeof(Analytics), typeof(Crashes));
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
