namespace MauiControls.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void commonControlButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CommonControls());
    }

    private void actionControlButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ActionControls());
    }

    private void inputControlButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InputControls());
    }

    private void indicatorControlButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new IndicatorControls());
    }

    private void drawingControlButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DrawingControls());
    }
}