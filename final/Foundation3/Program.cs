using System;

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public string GetAddressInfo()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}

class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time}\nAddress: {address.GetAddressInfo()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Generic Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}

class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity} attendees";
    }
}

class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

class OutdoorGathering : Event
{
    private string weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement)
        : base(title, description, date, time, address)
    {
        this.weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {weatherStatement}";
    }
}

class Program
{
    static void Main()
    {
        Address eventAddress = new Address("123 Main St", "Anytown", "CA", "USA");

        Event genericEvent = new Event("Generic Event", "A generic event description", DateTime.Now, new TimeSpan(2, 0, 0), eventAddress);
        Lecture lecture = new Lecture("Interesting Lecture", "Learn about fascinating topics", DateTime.Now, new TimeSpan(3, 0, 0), eventAddress, "John Doe", 50);
        Reception reception = new Reception("Fun Reception", "Join us for a night of fun", DateTime.Now, new TimeSpan(4, 0, 0), eventAddress, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Nature Gathering", "Enjoy the outdoors", DateTime.Now, new TimeSpan(5, 0, 0), eventAddress, "Sunny with a chance of rain");

        Console.WriteLine("Generic Event:\n" + genericEvent.GetFullDetails() + "\n");
        Console.WriteLine("Lecture:\n" + lecture.GetFullDetails() + "\n");
        Console.WriteLine("Reception:\n" + reception.GetFullDetails() + "\n");
        Console.WriteLine("Outdoor Gathering:\n" + outdoorGathering.GetFullDetails());
    }
}