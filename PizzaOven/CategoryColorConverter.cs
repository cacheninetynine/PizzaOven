using System;
using System.Windows.Data;
using System.Windows.Media;
using System.Collections.Generic;

namespace PizzaOven
{
    public class CategoryColorConverter : IValueConverter
    {
        private static readonly Dictionary<string, Color> _categoryColors = new Dictionary<string, Color>
        {
            {"BugFix", Color.FromRgb(255, 78, 78)},
            {"Overhaul", Color.FromRgb(255, 78, 78)},
            {"Addition", Color.FromRgb(108, 177, 255)},
            {"Feature", Color.FromRgb(108, 177, 255)},
            {"Tweak", Color.FromRgb(255, 94, 157)},
            {"Improvement", Color.FromRgb(255, 94, 157)},
            {"Optimization", Color.FromRgb(255, 94, 157)},
            {"Adjustment", Color.FromRgb(110, 255, 108)},
            {"Suggestion", Color.FromRgb(110, 255, 108)},
            {"Ammendment", Color.FromRgb(110, 255, 108)},
            {"Removal", Color.FromRgb(153, 153, 153)},
            {"Refactor", Color.FromRgb(153, 153, 153)},
        };

        private readonly SolidColorBrush _fallbackColor = new SolidColorBrush(Color.FromRgb(0, 0, 0));

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string category = (string)value;
            if (_categoryColors.TryGetValue(category, out Color color))
            {
                return new SolidColorBrush(color);
            }
            return _fallbackColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
