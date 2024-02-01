using WhatsAppProject.Views;

namespace WhatsAppProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }
    }
}
