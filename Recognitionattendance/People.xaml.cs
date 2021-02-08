using Recognitionattendance.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using SQLitePCL;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Recognitionattendance
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class People : Page
    {

        List<Users> people = new List<Users>();
        public People()
        {
            this.InitializeComponent();

            LoadPeopleList();
            peopleList.ItemsSource = null;
            peopleList.ItemsSource = people;
        }

        private void LoadPeopleList()
        {
            people.Add(new Users { LastName = "Uke", FirstName = "Emeka", ImageName = "https://docs.microsoft.com/zh-tw/windows/uwp/design/controls-and-patterns/images/image_licorice.jpg" });
            people.Add(new Users { LastName = "Nania", FirstName = "White", ImageName = "https://docs.microsoft.com/zh-tw/windows/uwp/design/controls-and-patterns/images/image_licorice.jpg" });
            people.Add(new Users { LastName = "Blint", FirstName = "may", ImageName = "https://docs.microsoft.com/zh-tw/windows/uwp/design/controls-and-patterns/images/image_licorice.jpg" });
            people.Add(new Users { LastName = "Tim", FirstName = "Corry", ImageName = "https://docs.microsoft.com/zh-tw/windows/uwp/design/controls-and-patterns/images/image_licorice.jpg" });
            people.Add(new Users { LastName = "White", FirstName = "Black", ImageName = "https://docs.microsoft.com/zh-tw/windows/uwp/design/controls-and-patterns/images/image_licorice.jpg" });

        }

        private void WireUpUserlist()
        {
            peopleList.ItemsSource = null;
            peopleList.ItemsSource = people;

        }
        private void PeopleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(People));
        }

        private void BackupButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Home));
        }

        private void AttendanceButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Attendance));
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Home));
        }
    }
}
