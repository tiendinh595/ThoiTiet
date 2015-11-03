using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ThoiTiet_WPF
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

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            imgBg.Opacity = imgSuny.Opacity = sldTimer.Value;
        }

        TextBlock txbSelected = new TextBlock();
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txbSelected.Margin = new Thickness(0, 15, 0, 0);
            txbSelected = (TextBlock)sender;
            txbSelected.Margin = new Thickness(0, 0, 0, 0);
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stpSelected = (StackPanel)sender;
            imgHinhThoiTiet.Source = ((Image)stpSelected.Children[1]).Source;
            txbNhietDo.Text = ((TextBlock)stpSelected.Children[2]).Text;
            txbGio.Text = "Wind: " + ((TextBlock)stpSelected.Children[3]).Text.Substring(3);
            txbDoAm.Text = "Humidity: " + ((TextBlock)stpSelected.Children[4]).Text.Substring(3);
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
