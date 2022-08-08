using EmergingBooking.Infrastructure.Cqrs.Domain;

namespace EmergingBooking.Management.Application.Domain;

internal class Hotel : Aggregate
{
    private IList<Room> _rooms;

    public Hotel(
        string name, int starsOfCategory, Address address, Contacts contacts, Guid code = default(Guid), Guid? identifier = null) : base(identifier)
    {
        Name = name;
        StarsOfCategory = starsOfCategory;
        StarsOfRating = 0;
        Address = address;
        Contacts = contacts;

        //ToDo
        Code = code;

        if (Code == default(Guid))
        {
            Code = Guid.NewGuid();

            //ToDo: events
        }
    }

    public string Name { get; }
    public int StarsOfCategory { get; }
    public int StarsOfRating { get; }
    public Address Address { get; private set; }
    public Contacts Contacts { get; private set; }
    public Guid Code { get; }

    public IEnumerable<Room> Rooms
    {
        get => _rooms.ToList();
        set => _rooms = value.ToList();
    }

    public void ChangeAddress(Address address)
    {
        Address = address;

        //ToDo: evento
    }

    public void ChangeContacts(Contacts contacts)
    {
        Contacts = contacts;
    }

    public void AddRoom(Room room)
    {
        if (_rooms.Contains(room))
        {
            throw new InvalidOperationException($"The room {room.Name} already was added.");
        }

        _rooms.Add(room);

        //ToDo: evento
    }

    public void AddRooms(IEnumerable<Room> rooms)
    {
        foreach (var room in rooms)
        {
            if (_rooms.Contains(room))
            {
                throw new InvalidOperationException($"The room {room.Name} already was added.");
            }

            _rooms.Add(room);
        }
    }

    public void RemoveRoom(Room room)
    {
        if (!_rooms.Contains(room))
        {
            throw new InvalidOperationException($"The room {room.Name} doesn't exists to be removed.");
        }

        _rooms.Remove(room);
    }
}