namespace WhatsAppProject.Views;

public partial class TabbedPageDemo : TabbedPage
{
	public TabbedPageDemo()
	{
		InitializeComponent();
	}
    public TabbedPageDemo(string userNAme)
    {
        InitializeComponent();
        var firstNavPage = this.Children[0] as NavigationPage;

        if (firstNavPage != null)
        {
            firstNavPage.CurrentPage.Title = "Welcome " + userNAme + "!!";
        }
    }
}