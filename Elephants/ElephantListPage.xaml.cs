namespace Elephants;

public partial class ElephantListPage : ContentPage
{
	private ElephantStore _store;

	public ElephantListPage()
	{
		InitializeComponent();
		
        _store = new ElephantStore();

		BindingContext = _store;
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Elephant ele = e.Item as Elephant;

        ShellNavigationQueryParameters navParamters;

        if (ele != null)
        {
            navParamters = new ShellNavigationQueryParameters();
            navParamters.Add("Elephant", ele);

            Shell.Current.GoToAsync("elephantdetail", navParamters);
        }

       
       
    }





    /*    Elephant elephant = 
         var navigationParameter = new ShellNavigationQueryParameters
    {
        { "Elephant", elephant }
    };
    
        await Shell.Current.GoToAsync("elephantpage",navigationParameter);
    */
}