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
                if (MessageBox.Show("Ban muon thoat chuong trinh", "thoat ?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.OK)
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

        StackPanel stpSelected = new StackPanel();
        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            stpSelected.Margin = new Thickness(0, 15, 0, 0);
            stpSelected = (StackPanel)sender;
            stpSelected.Margin = new Thickness(0, 0, 0, 0);

            imgHinhThoiTiet.Source = ((Image)stpSelected.Children[1]).Source;
            txbNhietDo.Text = ((TextBlock)stpSelected.Children[2]).Text;
            txbGio.Text = "Wind: " + ((TextBlock)stpSelected.Children[3]).Text.Substring(3);
            txbDoAm.Text = "Humidity: " + ((TextBlock)stpSelected.Children[4]).Text.Substring(3);
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(MessageBox.Show("Ban muon thoat chuong trinh", "thoat ?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.OK)
                this.Close();
        }
    }
}
