using System.ComponentModel.DataAnnotations;

namespace PhBet5.Models
{
    public class UserModel
    {
        [Key]public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; } = 200;
    }
}
