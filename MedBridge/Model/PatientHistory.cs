using System;
using System.Text.Json.Serialization;

namespace MedBridge.Model;

public class PatientHistory
{
    [JsonPropertyName("PatientId")]
    public string? PatientId { get; set; }
    [JsonPropertyName("Injury")]
    public Options Injury { get; set; }
    [JsonPropertyName("Smoker")]
    public Options Smoker { get; set; }
    [JsonPropertyName("Pregnant")]
    public Options Pregnant { get; set; }
    [JsonPropertyName("Hypertension")]
    public Options Hypertension { get; set; }
    [JsonPropertyName("Diabetes")]
    public Options Diabetes { get; set; }

    [JsonPropertyName("WeightLoss")]
    public Options WeightLoss { get; set; }
    [JsonPropertyName("WeightGain")]
    public Options WeightGain { get; set; }
}
