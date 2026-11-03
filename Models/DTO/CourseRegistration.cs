using System.ComponentModel.DataAnnotations;
public class RegistrationModel
{
    [Required(ErrorMessage = "Full Name is required.")]
    public string FullName { get; set; }
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Phone Number is required.")]
    [RegularExpression(@"^\+?\d{10,15}$", ErrorMessage = "Invalid phone number format.")]
    public string PhoneNumber { get; set; }
    [Required(ErrorMessage = "Course selection is required.")]
    public string Course { get; set; }
    [Required(ErrorMessage = "Study Mode is required.")]
    public string StudyMode { get; set; }
    [Required(ErrorMessage = "Start Date is required.")]
    public DateTime StartDate { get; set; }
    public string Comments { get; set; }
    [Required(ErrorMessage = "You must agree to the terms.")]
    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms.")]
    //]
    public bool AgreeTerms { get; set; }
}



// cách giải qiuyết van de validate email và phone number
