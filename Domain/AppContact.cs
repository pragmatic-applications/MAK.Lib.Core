namespace Domain;

/// <summary>
/// A type that is used for contact data with Contact features used Apps that use this library. the type can be inherited to add other members.
/// </summary>
public class AppContact
{
    public int Id { get; set; }

    [StringLength(50, MinimumLength = 1), Required, Display(Name = DataAnnotationValue.DisplayName_FirstName)]
    public string FirstName { get; set; }

    [StringLength(50, MinimumLength = 1), Required, Display(Name = DataAnnotationValue.DisplayName_LastName)]
    public string LastName { get; set; }

    [EmailAddress, Required, Display(Name = DataAnnotationValue.DisplayName_Email)]
    public string Email { get; set; }

    [Required, Display(Name = DataAnnotationValue.DisplayName_Message)]
    public string Message { get; set; }

    [Required, Display(Name = DataAnnotationValue.DisplayName_Title)]
    public string Title { get; set; }
    public List<string> Titles
    {
        get
        {
            return new List<string>
                {
                    "Mr",
                    "Miss",
                    "Ms",
                    "Mrs",
                    "Dr"
                };
        }
    }
}
