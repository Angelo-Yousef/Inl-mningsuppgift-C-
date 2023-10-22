using InlämningsuppgiftG.Models;

namespace InlämningsuppgiftG.Interfaces;

public interface ICustomer                      // Samma sak som IAddress, denna interface gör så att egenskaperna nedan måste implementeras.
{
    public DateTime Created { get => Created; set => Created = value; }
    Address? FullAddress { get; set; }
    string? Email { get; set; }
    string? FirstName { get; set; }
    string? LastName { get; set; }
    string? PhoneNumber { get; set; }
    string? FullName { get; }

}