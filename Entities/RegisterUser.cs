using System.ComponentModel.DataAnnotations;

namespace StoreBackEnd.Entities
{
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


    }
}
