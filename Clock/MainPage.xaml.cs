namespace Clock;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}


    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is BoxView myBoxView)
        {
            //myBoxView.WidthRequest += 10;
            await myBoxView.RelRotateTo(90, 300);
        }
    }
}

