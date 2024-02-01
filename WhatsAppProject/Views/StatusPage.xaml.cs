namespace WhatsAppProject.Views;

public partial class StatusPage : ContentPage
{
	public IList<Contact> Contacts { get; private set; }
	public StatusPage()
	{
		InitializeComponent();
		createPerson();
		BindingContext = this;
	}

	void createPerson()
	{
		Contacts = new List<Contact>();

		Contacts.Add(new Contact {
			Name = "Ethan",
			Posted = "10 min ago",
            Message = "Okay",
            Time = "09:04",
			ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Contacts.Add(new Contact
        {
            Name = "Vicardo",
            Posted = "10h ago",
            Message = "Okay",
            Time = "09:04",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
        });
        Contacts.Add(new Contact
        {
            Name = "Brandon Mack",
            Posted = "11h ago",
            Message = "Okay",
            Time = "09:04",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
        });
        Contacts.Add(new Contact
        {
            Name = "Tylin Richards",
            Posted = "20h ago",
            Message = "Okay",
            Time = "09:04",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
        });
        Contacts.Add(new Contact
        {
            Name = "Jason",
            Posted = "23h ago",
            Message = "Okay",
            Time = "09:04",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
        });
    }
}