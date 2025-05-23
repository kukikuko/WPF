﻿using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfExplorer.Support.Local.Converters
{
    public class DepthConverter : MarkupExtension, IValueConverter
    {
        public override object? ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            int depth = int.Parse(value.ToString());
            int left = depth * 10;
            Thickness thickness = new Thickness(left, 0, 0, 0);

            return thickness;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
