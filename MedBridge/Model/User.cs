using System;
using System.Text.Json.Serialization;
namespace MedBridge.Model;

public class User
{
    [JsonPropertyName("Id")]
    public string? Id { get; set; }
    [JsonPropertyName("FirstName")]
    public string? FirstName { get; set; }
    [JsonPropertyName("LastName")]
    public string? LastName { get; set; }
    [JsonPropertyName("Email")]
    public string? Email { get; set; }
    [JsonPropertyName("Gender")]
    public string Gender { get; set; } = "Male";
    [JsonPropertyName("InsuranceId")]
    public string? InsuranceId { get; set; }
    public string? Password { get; set; }
    [JsonPropertyName("DOB")]
    public DateTime? DOB { get; set; }
    [JsonPropertyName("dateTime")]
    public DateTime? dateTime { get; set; } = DateTime.Now;

}
