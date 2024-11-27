namespace BookingTestDrive.Dto.Common;

public class CommonResponseDto
{
    public int responseCode { get; set; } 
    public int codeSystem { get; set; } 
    public string message { get; set; } 
    public object result { get; set; } 
}