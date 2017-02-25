using System;
using Xamarin.Forms;

namespace ToDoList
{
	public enum HappeningType {
		Birthday,
		Meeting,
		Chore,
		Other
	}

	public class Happening
	{
		public string Title { get; private set; }

		public string Description { get; private set; }

		public HappeningType HappenningType
		{
			get;
			private set;
		}

		public Happening(string title,  string description, HappeningType happeningType)
		{
			this.Title = title;
			this.Description = description;
			this.HappenningType = happeningType;
		}
	}
}
