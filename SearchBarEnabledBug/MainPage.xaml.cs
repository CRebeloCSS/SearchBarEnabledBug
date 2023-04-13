namespace SearchBarEnabledBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
		//Workaround to force out Keyboard
        searchBar.IsVisible = false;
        searchBar.IsVisible = true;
    }
}

