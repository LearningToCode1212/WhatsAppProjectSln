using WhatsAppProject.Views;

namespace WhatsAppProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           //           var navPage = new NavigationPage(new Views.TabbedPageDemo());

         //              navPage.Title = "WhatsApp";
            MainPage = new TabbedPageDemo();
        }
    }
}
