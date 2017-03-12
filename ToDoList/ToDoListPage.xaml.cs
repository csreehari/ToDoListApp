using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace ToDoList
{
	public partial class ToDoListPage : ContentPage
	{
		ObservableCollection<Happening> happenings = new ObservableCollection<Happening>();

		public ObservableCollection<Happening> Happenings
		{
			get;
			set;
		}

		public ToDoListPage()
		{
			InitializeComponent();

			happenings = new ObservableCollection<Happening>
			{
				new Happening("Shekar's Birthday", "Gotta ask for party", HappeningType.Birthday, DateTime.Now),
				new Happening("Team Meeting", "Let's meet up for the Daily Scrum", HappeningType.Meeting, DateTime.Now),
				new Happening("Cleanup Mess", "Cleanup the mess once you are in", HappeningType.Chore, DateTime.Now),
				new Happening("Buy Groceries", "Buy groceries post dinner", HappeningType.Other, DateTime.Now)
			};
			GetHappeningsForDate(DateTime.Now);
			// Bind the data to the ListView
		}

		void Handle_OnCalendarTapped(object sender, Syncfusion.SfCalendar.XForms.CalendarTappedEventArgs args)
		{
			GetHappeningsForDate(args.datetime);
		}

		public void GetHappeningsForDate(DateTime dateRequested)
		{
			ListViewEventsToDo.ItemsSource = new ObservableCollection<Happening>(happenings.Where(s => s.OccurrenceDate.Date == dateRequested.Date));
		}
	}
}
