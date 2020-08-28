﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TimePickerFlyoutTest.Shared;
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

namespace TimePickerFlyoutTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private TimeSpan time;

        public TimeSpan Time
        {
            get => time;
            set
            {
                time = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Time"));
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = this;
        }

        private void Navigate_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Page2));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
