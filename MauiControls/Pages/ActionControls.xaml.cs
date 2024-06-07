namespace MauiControls.Pages;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}

    private void demoButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Artem Kuzmenko", "You've just clicked the demo button", "OK");
    }

    private void demoImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Artem Kuzmenko", "You've just clicked the trash button", "OK");
    }

    private void demoSearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Artem Kuzmenko", $"You've searched for {demoSearchBar.Text}", "OK");
    }

    private void facebookSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Artem Kuzmenko", "You've clicked Facebook button", "OK");
    }

    private void instagramSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Artem Kuzmenko", "You've clicked Instagram button", "OK");
    }

    private void twitterSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Artem Kuzmenko", "You've clicked Twitter button", "OK");
    }

    private void LinkedInSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Artem Kuzmenko", "You've clicked LinkedIn button", "OK");
    }
}