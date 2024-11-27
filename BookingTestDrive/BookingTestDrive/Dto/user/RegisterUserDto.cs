﻿namespace BookingTestDrive.Dto.user;

public class RegisterUserDto
{
    public string Username { get; set; } //= null!;
    public string Password { get; set; } //
    public int Role { get; set; } //1 = dealer, 2 = customer
    public string CustomerName { get; set; } // Customer's name
    public string CustomerEmail { get; set; } // Customer's email
    public string CustomerPhone { get; set; } // Customer's phone number
}