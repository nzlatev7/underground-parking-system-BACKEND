﻿namespace ParkingSpaces.Models.DB
{
    public class User
    {
        // Guid?
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Plate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
