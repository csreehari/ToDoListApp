using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using Syncfusion.SfCalendar.XForms.iOS;
using UIKit;

namespace ToDoList.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			//// define useragent android like
			//string userAgent = "Mozilla/5.0 (Linux; Android 5.1.1; Nexus 5 Build/LMY48B; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/43.0.2357.65 Mobile Safari/537.36";

			//// set default useragent
			//NSDictionary dictionary = NSDictionary.FromObjectAndKey(NSObject.FromObject(userAgent), NSObject.FromObject("UserAgent"));
			//NSUserDefaults.StandardUserDefaults.RegisterDefaults(dictionary);

			global::Xamarin.Forms.Forms.Init();

			Xamarin.Auth.Presenters.OAuthLoginPresenter.PlatformLogin = (authenticator) =>
			{
				var oAuthLogin = new OAuthLoginPresenter();
				oAuthLogin.Login(authenticator);
			};

			new SfCalendarRenderer();
			// The below is commented out as Microsoft's Mobile Center Services is not yet completely grown
			// So for now, Hockey App will be used instead.
			// When Switching to Mobile Center Services please add the packages and references required 
			// Configure the app secret code
			//MobileCenter.Configure("3e674a03-f471-4a60-93e7-9349c726392b");
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
