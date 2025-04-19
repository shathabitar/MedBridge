using System;
using System.Text.Json.Serialization;
namespace MedBridge.Model;

public class Transfer
{
    public string? Id { get; set; }
    [JsonPropertyName("PatientId")]
    public string? PatientId { get; set; } = null;
    [JsonPropertyName("OriginalDoctorId")]
    public string? OriginalDoctorId { get; set; } = null;
    [JsonPropertyName("DoctorId")]
    public string? DoctorId { get; set; } = null;
    [JsonPropertyName("HospitalId")]
    public string? HospitalId { get; set; } = null;
    [JsonPropertyName("Date")]
    public DateTime? Date { get; set; } = DateTime.Now;
    [JsonPropertyName("Status")]
    public TransferStatus? Status { get; set; } = TransferStatus.Requested;
}
