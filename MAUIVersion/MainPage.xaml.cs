using Microsoft.Maui.Controls;

namespace MAUIVersion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DisplayAlertClick(object sender, EventArgs e)
        {
            DisplayAlert("Нажата кнопка", "Вы нажали кнопку", "ОК");
        }
    }

}
