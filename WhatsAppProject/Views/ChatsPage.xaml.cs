namespace WhatsAppProject.Views;

public partial class ChatsPage : ContentPage
{
    public IList<Contact> Contacts { get; private set; }
    public ChatsPage()
    {
        InitializeComponent();
        createPerson();
        BindingContext = this;
    }

    void createPerson()
    {
        Contacts = new List<Contact>();

        Contacts.Add(new Contact
        {
            Name = "Ethan",
            Posted = "10 min ago",
            Message = "Okay..",
            Time = "09:04",
            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFile%3AVery_Black_screen.jpg&psig=AOvVaw2Udd7MVZznCqd30I44uZEy&ust=1706775500172000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCICtiLCYh4QDFQAAAAAdAAAAABAE"
        });
        Contacts.Add(new Contact
        {
            Name = "Vicardo",
            Posted = "10h ago",
            Message = "Testing..",
            Time = "09:04",
            Tick = "",
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
            Message = "Testing again...",
            Time = "09:04",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
        });
    }
}