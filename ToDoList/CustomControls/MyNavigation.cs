using System;
using Xamarin.Forms;

namespace ToDoList
{
	public class MyNavigation : NavigationPage
	{
		public MyNavigation()
		{
			
		}

		public MyNavigation(Page root) : base(root)
		{
			BarBackgroundColor = Color.Orange;
		}
	}
}
