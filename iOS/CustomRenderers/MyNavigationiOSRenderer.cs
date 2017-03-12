using System;
using ToDoList;
using ToDoList.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyNavigation), typeof(MyNavigationiOSRenderer))]
namespace ToDoList.iOS
{
	public class MyNavigationiOSRenderer : NavigationRenderer
	{
		
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			//if (e.NewElement != null)
			//{
			//	var element = (NavigationPage)e.NewElement;
			//}

		}
	}
}
