using Microsoft.AspNetCore.Identity;

namespace BlazerWebApp.Data;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Biography { get; set; }
    public string? ProfileImage { get; set; } = "avatar.png";
    public string Email { get; set; } = null!;
    //public string Password { get; set; } = null!;
    //public string ConfirmPassword { get; set; } = null!;
    //public string Terms { get; set; }

    public int? AddressId { get; set; }
    public AddressEntity? Address { get; set; }
}

public class AddressEntity
{
    public int Id { get; set; }
    public string AddressLine_1 { get; set; } = null!;
    public string? AddressLine_2 { get; set; }
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
}
