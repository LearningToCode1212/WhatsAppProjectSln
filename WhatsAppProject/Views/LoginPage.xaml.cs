namespace WhatsAppProject.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string username = LoginBtn.Text;
        App.Current.MainPage = new  TabbedPageDemo(username);
    }
}