namespace WhatsAppProject.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string userName = LoginBtn.Text;
        App.Current.MainPage = new  TabbedPageDemo(userName);
    }
}