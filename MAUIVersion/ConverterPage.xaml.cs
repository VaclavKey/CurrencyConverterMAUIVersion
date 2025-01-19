using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
namespace MAUIVersion;
using static ConverterViewModel;
public partial class ConverterPage : ContentPage
{
	public ConverterPage()
	{
		InitializeComponent();

        var viewModel = new ConverterViewModel
        {
            SafeAreaTop = this.SafeAreaInsets.Top,
            SafeAreaBottom = this.SafeAreaInsets.Bottom,
        };

        fromCurrencyImg.Source = FromCurrencyImg;
        fromCurrencyAbbr.Text = FromCurrencyAbbr;
        toCurrencyImg.Source = "usd.png";
		toCurrencyAbbr.Text = "USD";
    }
}