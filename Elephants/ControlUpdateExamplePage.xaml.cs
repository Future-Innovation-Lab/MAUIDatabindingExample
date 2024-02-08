namespace Elephants;

public partial class ControlUpdateExamplePage : ContentPage
{
	private int _demoValue;

	public int DemoValue
	{
		get { return _demoValue; }
		set { _demoValue = value;

			OnPropertyChanged();
		}
	}


	public ControlUpdateExamplePage()
	{
		InitializeComponent();

		var timer = Dispatcher.CreateTimer();
		timer.Interval = new TimeSpan(0, 0, 1);
        timer.Tick += Timer_Tick;
		timer.Start();
		



		BindingContext = this;
	}

    private void Timer_Tick(object? sender, EventArgs e)
    {
		DemoValue = DemoValue + 10;
    }
}