namespace BookingTestDrive.Model;

public class TestDriveBookingHistory
{
    public int Id { get; set; } //Unique identifier for the booking
    public int TestDriveBookingId { get; set; } // Foreign key to the TestDriveBooking
    public int Status { get; set; } // 0 still using or book, 1 available
    public string IdUser { get; set; }  //Foreign key to the userModel
}