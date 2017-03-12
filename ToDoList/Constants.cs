using System;

namespace ToDoList
{
	public static class Constants
	{
		public static string AppName = "TodoListApp";

		// OAuth
		// For Google login, configure at https://console.developers.google.com/
		public static string ClientId = "XXXXXXX";
		public static string ClientSecret = "XXXXX";

		// These values do not need changing
		public static string Scope = "https://www.googleapis.com/auth/calendar.readonly";
		public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
		public static string AccessTokenUrl = "https://accounts.google.com/o/oauth2/token";
		public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

		// Set this property to the location the user will be redirected too after successfully authenticating
		public static string RedirectUrl = "https://www.googleapis.com/plus/v1/people/me";
	}
}
