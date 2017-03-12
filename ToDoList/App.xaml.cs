using System.Collections.Generic;
using Xamarin.Forms;

namespace ToDoList
{
	public partial class App : Application
	{
		public static User User { get; set; }

		public App()
		{
			InitializeComponent();
			User = new User();

			MainPage = new MyNavigation(new ToDoListPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			// The below is commented out as Microsoft's Mobile Center Services is not yet completely grown
			// So for now, Hockey App will be used instead.
			// When Switching to Mobile Center Services please add the packages and references required
			// Start Mobile Center Analytics & Mobile Center Crashes services
			//MobileCenter.Start(typeof(Analytics), typeof(Crashes));
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
