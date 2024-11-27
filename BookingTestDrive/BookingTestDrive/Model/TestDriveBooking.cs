namespace BookingTestDrive.Model;

public class TestDriveBooking
{
    public int Id { get; set; } // Unique identifier for the booking
    public int CarModelId { get; set; } // Foreign key to the CarModel
    public int SlotCar { get; set; } // Selected time slot
}