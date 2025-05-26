namespace PinedaLMauiMay20;

public partial class StackLayoutPage : ContentPage
{
    public StackLayoutPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutPage());
    }
}
