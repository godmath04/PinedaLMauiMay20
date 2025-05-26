namespace PinedaLMauiMay20;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
	}

    private async void btnIrStack_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayoutPage());

    }
}