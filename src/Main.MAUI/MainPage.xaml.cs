using Lib.CppWinRT;

namespace Main.MAUI
{
    public partial class MainPage
    {
        private int _count;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            CounterBtn.Text = _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";
            SemanticScreenReader.Announce(CounterBtn.Text);
            var myStruct = new MyStruct();
            await DisplayAlert($"{myStruct}", $"1 + 1 = {myStruct.Add(1, 1)}", "OK");
        }
    }
}
