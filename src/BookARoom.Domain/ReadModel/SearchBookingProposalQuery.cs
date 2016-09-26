using System;

namespace BookARoom.Domain.ReadModel
{
    public class SearchBookingProposalQuery
    {
        public DateTime CheckInDate { get; } //Don't forget the timezone (confusion, ...), the timezone will be always for the target location (to the hotel)
        public DateTime CheckOutDate { get; } // Checkin/ Checkout date are night date, for a stay from 01/01/2016 => 01/01/2016 it is on night. For the algorithm it is better to use Half open interval : 01/01/2016 => 02/01/2016 even if the model impose night count.
        public string Location { get; }
        public int AdultsCount { get; }
        public int NumberOfRoomsNeeded { get; }
        public int ChildrenCount { get; }

        public SearchBookingProposalQuery(DateTime checkInDate, DateTime checkOutDate, string location, int adultsCount, int numberOfRoomsNeeded = 1, int childrenCount = 0)
        {
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            Location = location;
            AdultsCount = adultsCount;
            NumberOfRoomsNeeded = numberOfRoomsNeeded;
            ChildrenCount = childrenCount;
        }
    }
}
