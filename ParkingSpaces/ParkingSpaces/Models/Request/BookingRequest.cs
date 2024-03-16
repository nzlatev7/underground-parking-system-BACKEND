﻿namespace ParkingSpaces.Models.Request
{
    public class BookingRequest
    {
        public int ParkSpaceId { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
    }
}