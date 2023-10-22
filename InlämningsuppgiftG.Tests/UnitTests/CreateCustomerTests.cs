using InlämningsuppgiftG.Interfaces;
using InlämningsuppgiftG.Models;
using InlämningsuppgiftG.Services;

namespace InlämningsuppgiftG.Tests.UnitTests;

public class CreateCustomerTests
{
    [Fact]
    public async Task CreateCustomerAsync_ShouldCreateCustomerToList_ReturnTrue()   // ifall en skapad kund skapas och spraras i listan (CreateCustomer)
    {
        // Arrange
        ICustomerService customerService = new CustomerService();               // Skapar ny instans av ICustomerService
        var customer = new Customer                                             // Skapar en ny Customer och matar in allt själv
        {                                                                       // Det är detta vi vill testa och om de sparas vilket vi vill att de ska
                                                                                
            FirstName = "Angelo",
            LastName = "Yousef",
            Email = "angelo@gmail.com",
            PhoneNumber = "1234567890",
            FullAddress = new Address
            {
                StreetName = "Banangränd",
                StreetNumber = "11",
                ZipCode = "55555",
                City = "Stockholm"
            }
        };


        // Act 
        await customerService.CreateCustomerAsync(customer);        // Skapar/lägger till kunden till listan


        // Assert
        var retrievedCustomer = customerService.GetOneCustomer(customer.Email); // Kunden hämtas genom GetOneCustomer funktionen, och det sker med email address

        Assert.NotNull(retrievedCustomer);                                      // ska inte vara null
        Assert.Equal(customer.FullName, retrievedCustomer.FullName);            // ska ha samma för och Efternamn som kunden vi har angett ovan
        Assert.Equal(customer.Email, retrievedCustomer.Email);                  // ska ha samma email som kunden vi hämtar från den sparade listan
        Assert.Equal(customer.PhoneNumber, retrievedCustomer.PhoneNumber);      // ska ha samma telefonnummer som kunden vi hämtar från den sparade listan
        Assert.Equal(customer.FullAddress?.FullAddress, retrievedCustomer.FullAddress?.FullAddress); // Testar ifall kunden vi har angett har sparats och hämtas från listan
    }

}