namespace BookARoom.Domain.ReadModel
{
    public class RoomWithPrices
    {
        public string RoomIdentifier; //In Fact, in business term, this is called the room code. Code identity the kind of a room twin, double single
        public Price PriceForOneAdult; //This is call OneAdultOccupancy
        public Price PriceForTwoAdults; //TwoAdultOccupancy
        
        //What about Breakfast it is a common use, you can simplify by adding a fixed price for the breakfast? 
        
        public RoomWithPrices(string roomIdentifier, Price priceForOneAdult, Price priceForTwoAdults)
        {
            RoomIdentifier = roomIdentifier;
            PriceForOneAdult = priceForOneAdult;
            PriceForTwoAdults = priceForTwoAdults;
        }
    }
}
