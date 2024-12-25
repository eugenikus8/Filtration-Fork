using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Filtration.ObjectModel.Enums;
using System.Windows.Media;

namespace Filtration.Converters
{
	internal class MinimapIconToCroppedBitmapConverter : IMultiValueConverter
	{
		private static readonly int cellHeight = 64;
		private static readonly int cellWidth = 64;
		private static readonly int emptyColumn = 11;
		private static readonly int emptyRow = 1;
		private static readonly int colorCount = Enum.GetNames(typeof(IconColor)).Length;
		private static readonly int shapeCount = Enum.GetNames(typeof(IconShape)).Length;
		private static readonly float sizeSmall = 0.4f;
		private static readonly float sizeMedium = 0.5f;
		private static readonly float sizeLarge = 0.6f;
		private static readonly Uri uri;
		private static readonly CroppedBitmap empty;
		private static readonly List<CroppedBitmap> bitmaps;

		static MinimapIconToCroppedBitmapConverter()
		{
			uri = new Uri("pack://application:,,,/Filtration;component/Resources/minimap_icons.png", UriKind.Absolute);
			var sourceImage = new BitmapImage(uri);

			var emptyRect = new Int32Rect
			{
				Width = cellWidth,
				Height = cellHeight,
				X = emptyColumn * cellWidth,
				Y = emptyRow * cellHeight
			};
			
			empty = new CroppedBitmap(new BitmapImage(uri), emptyRect);
			bitmaps = new List<CroppedBitmap>(shapeCount * colorCount);

			for (var i = 0; i < shapeCount; i++) {
				for (var j = 0; j < colorCount; j++) {				
					var bitmapRect = new Int32Rect
					{
						Width = cellWidth,
						Height = cellHeight,
						X = j * cellWidth,
						Y = i * cellHeight
					};

					bitmaps.Add(new CroppedBitmap(sourceImage, bitmapRect));					
				}
			}
		}
		
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			if (values[0] == DependencyProperty.UnsetValue ||
				values[1] == DependencyProperty.UnsetValue ||
				values[2] == DependencyProperty.UnsetValue)
			{
				return empty;
			}

			var iconSize = (int)(values[0]);
			var iconColor = (int)(values[1]);
			var iconShape = (int)(values[2]);

			if (!Enum.IsDefined(typeof(IconSize), iconSize) ||
				!Enum.IsDefined(typeof(IconColor), iconColor) ||
				!Enum.IsDefined(typeof(IconShape), iconShape))
			{
				return empty;
			}

			var shapeOffset = iconShape * colorCount;
			var iconIndex = shapeOffset + iconColor;

			if (iconIndex >= bitmaps.Count)
			{
				return empty;
			}
			else
			{
				float size = 0;
				switch(iconSize) {
					case (int)IconSize.Small: 
						size = sizeSmall;
						break;
					case (int)IconSize.Medium: 
						size = sizeMedium;
						break;
					case (int)IconSize.Largest: 
						size = sizeLarge;
						break;
				}
				                 
				return new TransformedBitmap(bitmaps[iconIndex], new ScaleTransform(size, size));
			}
		}

		public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
