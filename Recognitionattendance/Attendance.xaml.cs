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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Recognitionattendance
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Attendance : Page
    {
        public Attendance()
        {
            this.InitializeComponent();
        }

        private void DatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {

        }

      

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Home));
        }

        private void BackupButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PeopleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(People));
        }
    }
}
