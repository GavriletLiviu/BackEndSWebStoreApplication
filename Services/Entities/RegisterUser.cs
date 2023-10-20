using System.ComponentModel.DataAnnotations;

namespace Services.Entities;

public class RegisterUser
{
    [Key]
    [StringLength(40)]
    public string UserName { get; set; }

    [StringLength(40)]
    public string Email { get; set; }

    [StringLength(40)]
    public string Password { get; set; }

    [StringLength(40)]
    public string ConfirmPassword { get; set; }

    public RegisterUser(string UserName, string Email, string Password, string ConfirmPassword)
    {
        this.UserName = UserName;
        this.Email = Email;
        this.Password = Password;
        this.ConfirmPassword = ConfirmPassword;
    }


}
