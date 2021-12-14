using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using MyLib;
using Windows.UI.Popups;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Main.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
            var myStruct = new MyStruct();
            var dialog = new MessageDialog($"1 + 1 = {myStruct.Add(1, 1)}", $"{myStruct}");
            await dialog.ShowAsync();
        }
    }
}
