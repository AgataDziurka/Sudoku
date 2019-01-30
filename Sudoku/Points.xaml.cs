using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sudoku
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Points : Page
    {
        public Points()
        {
            this.InitializeComponent();
            Windows.Storage.ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
            Object value = roamingSettings.Values["punkty"];
            if (value != null)
            {
                PointBlock.Text = value.ToString();
            }
        }

        /*private void Back1_Click(object sender, RoutedEventArgs e)
        {
            var grid = this.Frame.Parent as Grid;
            var page = grid.Parent as MainPage;
            var mainframe = page.Parent as Frame;
            mainframe.Navigate(typeof(MainPage));
        }
        */

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
            roamingSettings.Values["punkty"] = "0";
            PointBlock.Text = "0";
        }
    }
}
