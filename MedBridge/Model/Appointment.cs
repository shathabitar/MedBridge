using System;
using System.Text.Json.Serialization;

namespace MedBridge.Model;

public class Appointments
{
    public string? Id { get; set; } // Primary key
    public string? DoctorId { get; set; } // Foreign key
    public DateTime AppointmentDate { get; set; }
    [JsonPropertyName("PatientId")]
    public string? PatientId { get; set; }
    [JsonPropertyName("HospitalId")]
    public string? HospitalId { get; set; }
    [JsonPropertyName("DoctorSpecialty")]
    public string? DoctorSpecialty { get; set; }
    [JsonPropertyName("Booked")]
    public bool? Booked { get; set; } = false;
    [JsonPropertyName("transfer")]
    public bool? transfer { get; set; } = false;
}