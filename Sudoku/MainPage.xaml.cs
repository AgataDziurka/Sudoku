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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Sudoku
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Frame_1.Navigate(typeof(Info));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            Frame_1.Margin = new Thickness(200, 0, 0, 0);
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IconsListBox.SelectedIndex == 0)
            {
                Frame_1.Navigate(typeof(Info));
            }

            if (IconsListBox.SelectedIndex == 1)
            {
                Frame_1.Navigate(typeof(Levels));
            }

            if (IconsListBox.SelectedIndex == 3)
            {
                Frame_1.Navigate(typeof(Points));
            }

            if (IconsListBox.SelectedIndex == 2)
            {
                Frame_1.Navigate(typeof(Time_mode));
            }
        }

        private void MySplitView_PaneClosing(SplitView sender, SplitViewPaneClosingEventArgs args)
        {
            Frame_1.Margin = new Thickness(56, 0, 0, 0);
        }
    }
}
