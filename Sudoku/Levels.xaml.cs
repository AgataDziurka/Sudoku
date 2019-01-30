﻿using System;
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
    public sealed partial class Levels : Page
    {
        public Levels()
        {
            this.InitializeComponent();
        }

        private void LevelListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LevelListBoxItem.SelectedIndex == 0)
            {
                var grid = this.Frame.Parent as Grid;
                var page = grid.Parent as MainPage;
                var mainframe = page.Parent as Frame;
                mainframe.Navigate(typeof(Begginer));
            }

            if (LevelListBoxItem.SelectedIndex == 1)
            {
                var grid = this.Frame.Parent as Grid;
                var page = grid.Parent as MainPage;
                var mainframe = page.Parent as Frame;
                mainframe.Navigate(typeof(Normal));
            }

            if (LevelListBoxItem.SelectedIndex == 2)
            {
                var grid = this.Frame.Parent as Grid;
                var page = grid.Parent as MainPage;
                var mainframe = page.Parent as Frame;
                mainframe.Navigate(typeof(Hard));
            }

        }
    }
}