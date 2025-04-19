using System;
using System.Text.Json.Serialization;
namespace MedBridge.Model;

public class Visits
{
    public string? Id { get; set; }

    [JsonPropertyName("PatientId")]
    public string? PatientId { get; set; } = null;

    [JsonPropertyName("MainComplaint")]
    public string? MainComplaint { get; set; } = null;

    [JsonPropertyName("Duration")]
    public string? Duration { get; set; } = null;

    [JsonPropertyName("Status")]
    public Status? Status { get; set; } = null;

    [JsonPropertyName("PresentSymptoms")]
    public string? PresentSymptoms { get; set; } = null;

    [JsonPropertyName("OtherConditions")]
    public string? OtherConditions { get; set; } = null;

    [JsonPropertyName("Diagnosis")]
    public string? Diagnosis { get; set; } = null;

    [JsonPropertyName("Prescription")]
    public string? Prescription { get; set; } = null;

    [JsonPropertyName("LabOrders")]
    public string? LabOrders { get; set; } = null;

    [JsonPropertyName("XRayOrders")]
    public string? XRayOrders { get; set; } = null;

    [JsonPropertyName("HospitalTransfers")]
    public string? HospitalTransfers { get; set; } = null;

    [JsonPropertyName("DoctorTransfers")]
    public string? DoctorTransfers { get; set; } = null;
    [JsonPropertyName("TransferId")]
    public string? TransferId { get; set; } = null;
    [JsonPropertyName("AppointmentId")]
    public string? AppointmentId { get; set; } = null;
}
