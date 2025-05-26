namespace PinedaLMauiMay20;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}

    private async void OnVolverGridClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayoutPage());
    }
}