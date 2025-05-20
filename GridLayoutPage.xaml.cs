namespace PinedaLMauiMay20;

public partial class GridLayoutPage : ContentPage
{
	public GridLayoutPage()
	{
		InitializeComponent();
	}

    private void btnIrStack_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackLayoutPage());

    }
}