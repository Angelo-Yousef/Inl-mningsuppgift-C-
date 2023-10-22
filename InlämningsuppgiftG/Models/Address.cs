using InlämningsuppgiftG.Interfaces;

namespace InlämningsuppgiftG.Models;

public class Address : IAddress                     // Denna class implementerar IAddress, dvs den definierar alla dessa egenskaper
{
    public string? StreetName { get; set; }
    public string? StreetNumber { get; set; }
    public string? City { get; set; }
    public string? ZipCode { get; set; }

    public string? FullAddress => $"{StreetName} {StreetNumber}, {ZipCode} {City} ";
}