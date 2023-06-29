using System;
using System.Drawing;
using System.Windows.Media;

namespace BrokPaint.Converter
{
    public class ConvertStringToColor
    {
        public static System.Windows.Media.Color StringToColor(string HexString)
        {
			try
			{
                if (HexString.StartsWith("#"))
                {
                    var color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(HexString);
                    return color;
                }
                else if (!HexString.StartsWith("#"))
                {
                    var color = (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString(HexString);
                    return color;
                }
                else
                    return System.Windows.Media.Colors.White;
            }
			catch (Exception)
            {
                return System.Windows.Media.Colors.White;
            }
        }
    }
}
