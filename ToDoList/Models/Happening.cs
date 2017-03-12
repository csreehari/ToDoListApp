using System;
using Xamarin.Forms;

namespace ToDoList
{
	/// <summary>
	/// Happening type.
	/// </summary>
	public enum HappeningType {
		Birthday,
		Meeting,
		Chore,
		Other
	}

	/// <summary>
	/// This is model to deal with Events, Meetings or any To Do Tasks
	/// </summary>
	public class Happening
	{
		public string Title { get; private set; }

		public string Description { get; private set; }

		public HappeningType OccurrenceType
		{
			get;
			private set;
		}

		public DateTime OccurrenceDate
		{
			get;
			set;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:ToDoList.Happening"/> class.
		/// </summary>
		/// <param name="title">Title.</param>
		/// <param name="description">Description.</param>
		/// <param name="occurrenceType">Occurrence type.</param>
		public Happening(string title,  string description, HappeningType occurrenceType, DateTime occcurrenceDate)
		{
			this.Title = title;
			this.Description = description;
			this.OccurrenceType = occurrenceType;
			this.OccurrenceDate = occcurrenceDate;
		}
	}
}
