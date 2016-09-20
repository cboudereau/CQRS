using System;
using System.Collections.Generic;

namespace BookARoom.Domain
{
    public interface ICatalogPlaces
    {
        IEnumerable<Place> SearchFromLocation(string location);
        IEnumerable<Place> SearchAvailablePlacesInACaseInsensitiveWay(string location, DateTime checkInDate, DateTime checkOutDate);
    }
}