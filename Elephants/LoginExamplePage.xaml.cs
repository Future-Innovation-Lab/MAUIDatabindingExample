namespace Elephants;

public partial class LoginExamplePage : ContentPage
{
	private string _emailAddress;

	public string EmailAddress
    {
		get { return _emailAddress; }
		set { _emailAddress = value;
			OnPropertyChanged();
		}
	}

	private string _password;

	public string Password
	{
		get { return _password; }
		set { _password = value;

			OnPropertyChanged();
		}
	}



	public LoginExamplePage()
	{
		InitializeComponent();

		BindingContext = this;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		EmailAddress = "adpead@gmail.com";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		 string emailAddress = EmailAddress;
         string password = Password;

		DisplayAlert("Login", emailAddress + " " + password, "Cancel");


    }
}