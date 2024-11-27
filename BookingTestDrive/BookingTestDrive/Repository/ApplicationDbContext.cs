using BookingTestDrive.Model;

namespace BookingTestDrive.Repository;

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<CarModel> CarModels { get; set; } // Table for car models
    public DbSet<UserModel> UserModels { get; set; } // Table for car models
    public DbSet<TestDriveBooking> TestDriveBookings { get; set; } // Table for test drive bookings
}