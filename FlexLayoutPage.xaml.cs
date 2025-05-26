namespace PinedaLMauiMay20;

public partial class FlexLayoutPage : ContentPage
{
    public FlexLayoutPage()
    {
        InitializeComponent();
    }

    private async void OnGoToAbsoluteLayoutClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}
