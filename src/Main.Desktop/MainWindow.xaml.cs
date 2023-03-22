// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using Lib.CppWinRT;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Main.Desktop
{
    /// <summary>
    ///     An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            MyButton.Content = "Clicked";
            var myStruct = new MyStruct();
            var dialog = new ContentDialog
            {
                Title = myStruct,
                Content = $"1 + 1 = {myStruct.Add(1, 1)}",
                PrimaryButtonText = "OK",
                XamlRoot = Content.XamlRoot
            };
            await dialog.ShowAsync();
        }
    }
}
