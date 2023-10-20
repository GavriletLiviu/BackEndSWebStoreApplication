using System.ComponentModel.DataAnnotations;


namespace StoreBackEnd.Entities
{
    public class User
    {
        [Key]
        [StringLength(40)]
        public string UserName { get; set; }

        [StringLength(40)]
        public string Password { get; set; }

    }
}
