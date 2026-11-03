using System.ComponentModel.DataAnnotations;
/*
    Validation: 
    + Kiểm tra rỗng 
    + Kiểm tra định dạng (định dạng email, số điện thoại, mật khẩu, các trường khác nếu có, độ dài ký tự, giá trị hợp lệ) - Regex: regular expression
    + So sánh mật khẩu (nếu có trường xác nhận mật khẩu)

*/



using System.ComponentModel.DataAnnotations;

public class RegisterModel{
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; }

    // @"\A(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9\s])[^\s]{6,32}\z";
    [RegularExpression(@"\A(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9\s])[^\s]{6,32}\z", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, one special character, and be 6-32 characters long")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }

    //Password confirm
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    [Required(ErrorMessage = "Confirm Password is required")]
    public string ConfirmPassword { get; set; }


    [Required(ErrorMessage = "FullName is required")]
    [RegularExpression(@"^[a-zA-Z\s]{2,50}$", ErrorMessage = "FullName must be 2-50 characters long and contain only letters and spaces")]
    public string FullName { get; set; }
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format")]
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }

    [RegularExpression(@"^\+?\d{10,15}$", ErrorMessage = "Invalid phone number format")]
    [Required(ErrorMessage = "Phone is required")]
    public string Phone { get; set; }
    public string Gender { get; set; }
}