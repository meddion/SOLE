﻿using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfUI.Converters
{
    [ValueConversion(typeof(Matrix), typeof(DataTable))]
    public class MatrixToDataGridConverter : MarkupExtension, IValueConverter 
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var array = value as Matrix;
            if (array == null) return null;
            var rows = array.Size;
            if (rows == 0) return null;
            var columns = array.Size;
            if (columns == 0) return null;
            var t = new DataTable();
            // Add columns with name "0", "1", "2", ...
            for (var c = 0; c < columns; c++)
            {
                t.Columns.Add(new DataColumn());
            }
            // Add data to DataTable
            for (var r = 0; r < rows; r++)
            {
                var newRow = t.NewRow();
                for (var c = 0; c < columns; c++)
                {
                    newRow[c] = array[r, c];
                }
                t.Rows.Add(newRow);
            }
            return t.DefaultView;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
