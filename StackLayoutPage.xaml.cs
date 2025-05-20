namespace PinedaLMauiMay20;

public partial class StackLayoutPage : ContentPage
{
    public StackLayoutPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayoutPage());
    }
}
