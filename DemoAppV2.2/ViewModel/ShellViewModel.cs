using DemoAppV2._2.MVVM;
using MahApps.Metro.IconPacks;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace DemoAppV2._2.ViewModel
{
    internal class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menus
            Menu.Add(new MenuItem()
            {
                Icon = new PackIconMaterial { Kind = PackIconMaterialKind.HomeOutline },
                Text = "Page 1",
                NavigationDestination = new Uri("Views/Page1.xaml", UriKind.RelativeOrAbsolute),
                Command = new DelegateCommand(() => MessageBox.Show($"Shown from Item 1"))
            });
            Menu.Add(new MenuItem()
            {
                Icon = new PackIconMaterial { Kind = PackIconMaterialKind.Map },
                Text = "Page 2",
                NavigationDestination = new Uri("Views/Page2.xaml", UriKind.RelativeOrAbsolute),
                Command = new DelegateCommand(() => MessageBox.Show($"Shown from Item 2"))
            });
            Menu.Add(new MenuItem()
            {
                Icon = new PackIconMaterial { Kind = PackIconMaterialKind.TableLarge },
                Text = "Page 3",
                NavigationDestination = new Uri("Views/Page3.xaml", UriKind.RelativeOrAbsolute),
                Command = new DelegateCommand(() => MessageBox.Show($"Shown from Item 3"))
            });
            Menu.Add(new MenuItem()
            {

                Icon = new PackIconMaterial { Kind = PackIconMaterialKind.Signal },
                Text = "Page 4",
                NavigationDestination = new Uri("Views/Page4.xaml", UriKind.RelativeOrAbsolute),
                Command = new DelegateCommand(() => MessageBox.Show($"Shown from Item 4"))
            });
        }
    }
}
