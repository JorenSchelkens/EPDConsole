﻿namespace Chipsoft.Assignments.EPDApplication.Models;

public class Patient
{
    public int Id { get; set; }
    public required string Firstname { get; set; }
    public required string Lastname { get; set; }
    public required string NationalRegistryNumber { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required DateTime DateOfBirth { get; set; }
    public required Address Address { get; set; }

    public int AddressId { get; set; }
}
