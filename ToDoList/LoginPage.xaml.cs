using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Auth;
using Xamarin.Forms;

namespace ToDoList
{
	public partial class LoginPage : ContentPage
	{
		//static MyNavigation _NavPage = new MyNavigation(new LoginPage());
		public LoginPage()
		{
			InitializeComponent();
		}

		public void OnSignInWithGoogle_Clicked(object sender, EventArgs args)
		{

			var auth = new OAuth2Authenticator(Constants.ClientId,
			                                   Constants.Scope,
			                                   new Uri(Constants.AuthorizeUrl),
			                                   new Uri(Constants.RedirectUrl));

			auth.Completed += OnAuthCompleted;
			auth.Error += OnAuthError;

			var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
			presenter.Login(auth);
		}

		async void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
		{
			var authenticator = sender as OAuth2Authenticator;

			if (authenticator != null)
			{
				authenticator.Completed -= OnAuthCompleted;
				authenticator.Error -= OnAuthError;
			}

			// We presented the UI, so it's up to us to dimiss it on iOS.

			if (e.IsAuthenticated)
			{
				OAuthConfig.SaveToken(e.Account.Properties["access_token"]);
				// On iOS:
				//AccountStore.Create().Save(eventArgs.Account, "Google");


				Navigation.InsertPageBefore(new ToDoListPage(), this);
				await Navigation.PopToRootAsync();
			}
			else
			{
				//user cancelled the login
			}
		}

		void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
		{
			var authenticator = sender as OAuth2Authenticator;

			if (authenticator != null)
			{
				authenticator.Completed -= OnAuthCompleted;
				authenticator.Error -= OnAuthError;
			}

			Debug.WriteLine("Authentication error: " + e.Message);
		}

		//public static Action SuccessfulLoginAction
		//{
		//	get
		//	{
		//		return new Action(() =>
		//		{
		//			_NavPage.Navigation.PopModalAsync();

		//		});
		//	}
		//}

		//public static void PresentLandingPage()
		//{
		//	if (OAuthConfig.IsAuthenticated)
		//	{
		//		_NavPage.Navigation.PushAsync(new ToDoListPage());
		//	}
		//}
	}
}
