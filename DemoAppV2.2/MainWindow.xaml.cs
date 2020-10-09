using MahApps.Metro.Controls;
using MenuItem = DemoAppV2._2.ViewModel.MenuItem;
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
using DemoAppV2._2.Views;

namespace DemoAppV2._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public int lastSelectedItemIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
            Navigation.Navigation.Frame = new Frame(); //SplitViewFrame;
            Navigation.Navigation.Frame.Navigated += OnNavigated;
            Navigation.Navigation.Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            HamburgerMenuControl.Content = Navigation.Navigation.Frame;

            WindowTitleBrush = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF28930D"));

            Title = $"";
        }

        private void GoBack_OnClick(object sender, RoutedEventArgs e)
        {
            Navigation.Navigation.GoBack();
        }

        private void OnNavigated(object sender, NavigationEventArgs e)
        {            
            GoBackButton.Visibility = Navigation.Navigation.Frame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
        }        

        private void OnMenuItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = e.ClickedItem as MenuItem;

            if (menuItem != null && menuItem.IsNavigation)
            {   
                if(lastSelectedItemIndex == HamburgerMenuControl.SelectedIndex)
                {
                    MessageBox.Show("We are navigating back to selected page in the hamburger menu");
                }
                else
                {
                    lastSelectedItemIndex = HamburgerMenuControl.SelectedIndex;
                }
                
                Navigation.Navigation.Navigate(menuItem.NavigationDestination);
            }
        }  

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            Navigation.Navigation.Navigate(new Page1());
            HamburgerMenuControl.SelectedIndex = 0;
        }
    }    
}
