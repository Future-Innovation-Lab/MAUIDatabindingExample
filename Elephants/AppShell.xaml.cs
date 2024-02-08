namespace Elephants
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("elephantdetail", typeof(ElephantDetailPage));
        }
    }
}
