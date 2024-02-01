namespace WhatsAppProject.Views;

public partial class SettingsPage : ContentPage
{
    public IList<Contact> Contacts { get; private set; }
    public SettingsPage()
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
            Call = "Outgoing",
            date = "Yesterday",
            Time = "09:04",
            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FFile%3AVery_Black_screen.jpg&psig=AOvVaw2Udd7MVZznCqd30I44uZEy&ust=1706775500172000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCICtiLCYh4QDFQAAAAAdAAAAABAE"
        });
        Contacts.Add(new Contact
        {
            Name = "Vicardo",
            Posted = "10h ago",
            Call = "Incoming",
            Message = "Testing..",
            date = "Yesterday",
            Time = "09:04",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
        });
    }
}