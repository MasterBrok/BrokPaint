using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BrokPaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void wPaint_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnBrush_Click(object sender, RoutedEventArgs e)
        {
            if (Converter.ConvertStringToColor.StringToColor(txtColorHEX.Text) is System.Windows.Media.Color meColor)
            {
                inPaint.DefaultDrawingAttributes.Color = meColor;
                inPaint.EditingMode = InkCanvasEditingMode.Ink;
                if (txtWidth.Text == "0" || txtHeight.Text == "0")
                {
                    txtHeight.Text = "5";
                    txtWidth.Text = "5";
                }
                inPaint.DefaultDrawingAttributes.Width = double.Parse(txtWidth.Text);
                inPaint.DefaultDrawingAttributes.Height = double.Parse(txtHeight.Text);
            }
        }

        private void btnEraser_Click(object sender, RoutedEventArgs e)
        {
            if (chPoint.IsChecked is true)
            {
                inPaint.EditingMode = InkCanvasEditingMode.EraseByPoint;
                chAll.IsChecked = false;
            }
            if (chAll.IsChecked is true)
            {
                inPaint.EditingMode = InkCanvasEditingMode.EraseByStroke;
                chPoint.IsChecked = false;
            }

        }

        private void Ellipse_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtColorHEX.Text = (sender as Ellipse).Fill.ToString();
        }
    }
}
