using System;
using Windows.UI.Popups;
using Lib.CppWinRT;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Main.UWP
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClick(object sender, RoutedEventArgs e)
        {
            MyButton.Content = "Clicked";
            var myStruct = new MyStruct();
            var dialog = new MessageDialog($"1 + 1 = {myStruct.Add(1, 1)}", $"{myStruct}");
            await dialog.ShowAsync();
        }
    }
}
