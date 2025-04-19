using System;

namespace MedBridge.Model;

public class Insurance
{
    public string? Id { get; set; } = "";
    public string? Name { get; set; } = "";
    public static string? GIG { get; set; } = "GIG";
    public static string? NatHealth { get; set; } = "NatHealth";
    public static string? Solidarity { get; set; } = "Solidarity";
}
