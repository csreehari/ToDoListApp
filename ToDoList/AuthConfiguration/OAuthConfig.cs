using System;
using Xamarin.Forms;

namespace ToDoList
{
	public static class OAuthConfig
	{
		
		private static string _token;
		public static string Token { get { return _token; } }
		public static bool IsAuthenticated { get { return !string.IsNullOrWhiteSpace(_token); } }

		public static void SaveToken(string token) => _token = token;


	}
}
