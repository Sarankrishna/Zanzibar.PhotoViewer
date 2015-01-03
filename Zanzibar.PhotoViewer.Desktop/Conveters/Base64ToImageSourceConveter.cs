

using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace Zanzibar.PhotoViewer.Desktop.Conveters
{
    [ValueConversion(typeof(byte[]), typeof(ImageSource))]
    public class Base64ToImageSourceConveter : IValueConverter
    {
        #region Implementation of IValueConverter

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var base64String = value as string;

            if (base64String != null && base64String.Length > 0)
            {

                var ms = new MemoryStream(System.Convert.FromBase64String(base64String));
 
                var bitmapImg = new BitmapImage();
 
                bitmapImg.BeginInit();
                bitmapImg.StreamSource = ms;
                bitmapImg.EndInit();

                return bitmapImg;
            }
 
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        #endregion
    }
}