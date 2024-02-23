﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParkingSpaces.Models.Request;
using ParkingSpaces.Services;
using System.Security.Claims;

namespace ParkingSpaces.Controllers
{
    [Route("[controller]/[action]")]
    [Authorize] // require to be authorized
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        public virtual async Task<ActionResult> CreateBooking(BookingCreateBookingRequest bookingRequest)
        {
            string username = User.Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)
                .Value;

            try
            {
                await _bookingService.CreateBooking(bookingRequest, username);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
   
        }

    }
}
