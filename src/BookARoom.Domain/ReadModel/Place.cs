namespace BookARoom.Domain.ReadModel
{
    public class Place // I think it is a Hotel due to member composition ?
    {
        public Place(int placeId, string name, string location, int numberOfRooms)
        {
            this.Identifier = placeId;
            this.Name = name;
            this.Location = location; // The location is important when you search an hotel not a room. This kind of info is usefull when you want details.
            this.NumberOfRooms = numberOfRooms; // Ok but number of rooms of which occupancy ? I think the location is the hotel. Try to book on expedia or booking and you can infer your model from the booking search result. They often use the hotel name in the title, ...
        }

        public string Location { get; }
        public string Name { get; }
        public int Identifier { get; }
        public int NumberOfRooms { get; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
