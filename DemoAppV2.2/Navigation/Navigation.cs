using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DemoAppV2._2.Navigation
{
    public static class Navigation
    {
        private static Frame frame;

        public static Frame Frame
        {
            get { return frame; }
            set { frame = value; }
        }

        public static bool Navigate(Uri sourcePageUri)
        {
            if (frame.CurrentSource != sourcePageUri)
            {
                return frame.Navigate(sourcePageUri);
            }
            return true;
        }

        public static bool Navigate(object content)
        {
            if (frame.NavigationService.Content != content)
            {
                return frame.Navigate(content);
            }
            return true;
        }

        public static void GoBack()
        {
            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }
    }
}
