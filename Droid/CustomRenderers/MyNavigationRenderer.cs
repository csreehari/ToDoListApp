using System;
using ToDoList;
using ToDoList.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyNavigation), typeof(MyNavigationRenderer))]
namespace ToDoList.Droid
{
	public class MyNavigationRenderer : NavigationPageRenderer
	{
		public MyNavigationRenderer()
		{
			
		}

		protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Xamarin.Forms.NavigationPage> e)
		{
			base.OnElementChanged(e);

			if (Element != null)
			{
				

			}

		}
	}
}
