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

		public HappeningType OccurrenceType
		{
			get;
			private set;
		}

		public Happening(string title,  string description, HappeningType occurrenceType)
		{
			this.Title = title;
			this.Description = description;
			this.OccurrenceType = occurrenceType;
		}
	}
}
