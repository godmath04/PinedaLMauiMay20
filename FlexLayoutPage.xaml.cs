namespace PinedaLMauiMay20;

public partial class FlexLayoutPage : ContentPage
{
    public FlexLayoutPage()
    {
        InitializeComponent();
    }

    private void btnRegresar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}
