using System;
using System.Globalization;
using Xamarin.Forms;

namespace ToDoList
{
	public class HpngTypeToColorConverter : IValueConverter
	{
		public Color HpngColor { get; set; }

		public HpngTypeToColorConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			switch ((HappeningType)value)
			{
				case HappeningType.Birthday:
					// mediumseagreen = #3CB371
					HpngColor = Color.FromHex("#3CB371");
					break;
				case HappeningType.Meeting:
					// royalblue = #4169E1
					HpngColor = Color.FromHex("#4169E1");
					break;
				case HappeningType.Chore:
					// Light Yellow = #FFFF99
					HpngColor = Color.FromHex("#FFFF99");
					break;
				default:
					// lightsteelblue = #B0C4DE
					HpngColor = Color.FromHex("#B0C4DE");
					break;
			}

			return HpngColor;

		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
