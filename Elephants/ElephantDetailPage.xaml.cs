namespace Elephants;

[QueryProperty(nameof(Elephant),"Elephant")]
	public partial class ElephantDetailPage : ContentPage
{
	private Elephant _elephant;

	public Elephant Elephant
	{
		get { return _elephant; }
		set { _elephant = value;

			OnPropertyChanged();
		
		}
	}



	public ElephantDetailPage()
	{
		InitializeComponent();

		BindingContext = this;
	}
}