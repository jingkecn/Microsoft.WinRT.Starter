using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace Main.MAUI
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var myStruct = new Lib.CppWinRT.MyStruct();
            CounterLabel.Text = $"1 + 1 = {myStruct.Add(1, 1)}";
            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}
