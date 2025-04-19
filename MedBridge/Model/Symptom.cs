using System;
using System.Text.Json.Serialization;

namespace MedBridge.Model;

public class Symptom
{
    public string? Id { get; set; }
    [JsonPropertyName("PatientId")]
    public string? PatientId { get; set; }
    [JsonPropertyName("Name")]
    public string? Name { get; set; }
    [JsonPropertyName("Severity")]
    public Severity Severity { get; set; }
    [JsonPropertyName("Duration")]
    public Duration Duration { get; set; }
}
