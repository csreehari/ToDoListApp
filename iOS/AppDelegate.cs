using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace ToDoList.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
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
