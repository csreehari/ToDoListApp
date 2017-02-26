using System.Collections.Generic;
using System.Collections.ObjectModel;
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
				new Happening("Shekar's Birthday", "Gotta ask for party", HappeningType.Birthday),
				new Happening("Team Meeting", "Let's meet up for the Daily Scrum", HappeningType.Meeting),
				new Happening("Cleanup Mess", "Cleanup the mess once you are in", HappeningType.Chore),
				new Happening("Buy Groceries", "Buy groceries post dinner", HappeningType.Other)
			};

			// Bind the data to the ListView
			ListViewEventsToDo.ItemsSource = happenings;
		}
	}
}
