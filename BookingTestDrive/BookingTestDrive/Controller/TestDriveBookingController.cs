// using System.ComponentModel.DataAnnotations;
// using BookingTestDrive.Model;
// using BookingTestDrive.Repository;
//
// namespace BookingTestDrive.Controller;
//
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System;
// using System.Threading.Tasks;
//
// [Route("api/[controller]")]
// [ApiController]
// public class TestDriveBookingController : ControllerBase
// {
//     private readonly ApplicationDbContext _context;
//
//     public TestDriveBookingController(ApplicationDbContext context)
//     {
//         _context = context;
//     }
//
//     // POST: api/testdrivebooking
//     [HttpPost]
//     public async Task<ActionResult<TestDriveBooking>> BookTestDrive(TestDriveBooking booking)
//     {
//         if (string.IsNullOrEmpty(booking.CustomerName) || 
//             string.IsNullOrEmpty(booking.CustomerEmail) || 
//             string.IsNullOrEmpty(booking.CustomerPhone))
//         {
//             return BadRequest("All fields are required.");
//         }
//
//         if (!new EmailAddressAttribute().IsValid(booking.CustomerEmail))
//         {
//             return BadRequest("Invalid email format.");
//         }
//
//         _context.TestDriveBookings.Add(booking);
//         await _context.SaveChangesAsync();
//         return CreatedAtAction(nameof(BookTestDrive), new { id = booking.Id }, booking);
//     }
//
//     // GET: api/testdrivebooking
//     [HttpGet]
//     public async Task<ActionResult<IEnumerable<TestDriveBooking>>> GetBookings()
//     {
//         return await _context.TestDriveBookings.ToListAsync();
//     }
//
//     // Additional methods for fetching bookings by customer or date can be added here...
// }