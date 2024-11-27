namespace BookingTestDrive.Model;

public class CarModel
{
    public int Id { get; set; } // Unique identifier for the car model
    public string Brand { get; set; } // Brand of the car (e.g., Hyundai)
    public string Model { get; set; } // Model name (e.g., Elantra)
    public int Year { get; set; } // Manufacturing year
    public string Image { get; set; } // URL or path to the car image
}