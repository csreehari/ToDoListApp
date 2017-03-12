using System;
using ToDoList;
using ToDoList.iOS;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ProviderLoginPage), typeof(LoginPageRenderer))]
namespace ToDoList.iOS
{
	public class LoginPageRenderer : PageRenderer
	{
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);


		}
	}
}
