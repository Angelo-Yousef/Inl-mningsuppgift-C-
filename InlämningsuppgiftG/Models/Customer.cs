
using InlämningsuppgiftG.Interfaces;

namespace InlämningsuppgiftG.Models;

public class Customer : ICustomer
// Jag gör en public class med all nödvändig information för en kund
{                                            
    public DateTime Created { get; set; } = DateTime.Now;       // Anledningen till att jag har med datum/tid
                                                                // är för att när man visar alla kunder, så kan de senare visas
                                                                // de i den tidsordningen då kunderna har skapats

    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public Address? FullAddress { get; set; } 

    public string? FullName => $"{FirstName} {LastName}"; 
}