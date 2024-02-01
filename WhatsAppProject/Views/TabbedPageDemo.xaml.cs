namespace WhatsAppProject.Views;

public partial class TabbedPageDemo : TabbedPage
{
	public TabbedPageDemo()
	{
		InitializeComponent();
	}
    public TabbedPageDemo(string name)
    {
        InitializeComponent();
        if (name != null)
        {
            string loginName = name;
        }
    }
}