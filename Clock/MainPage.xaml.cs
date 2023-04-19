namespace Clock;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		ChangeTime();
	}
    public async void ChangeTime()
	{
        int hour;
        int minute;
        int second;
        while (true) {
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
            firstNumber.ChangeGridForANumb(hour / 10);
            secondNumber.ChangeGridForANumb(hour % 10);
            thirdNumber.ChangeGridForANumb(minute / 10);
            fourthNumber.ChangeGridForANumb(minute % 10);
            fifthNumber.ChangeGridForANumb(second / 10);
            sixthNumber.ChangeGridForANumb(second % 10);
            await Task.Delay(1000);
        }
    }
    
}

