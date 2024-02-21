using System.ComponentModel.DataAnnotations;

namespace PhBet5.Models
{
	public class RegistrationModel
	{
		[Required(ErrorMessage = "Korisničko ime mora biti upisano.")]
		public string? UserName { get; set; }

		[Required(ErrorMessage = "E-mail mora biti upisan.")]
		public string? Email { get; set; }

		[Required(ErrorMessage = "Lozinka mora biti upisana.")]
		[MinLength(6, ErrorMessage = "Lozinka mora sadržavati minimalno 6 znakova.")]
		public string? Password { get; set; }

		[Compare("Password", ErrorMessage = "Lozinka i potvrda lozinke nisu iste.")]
		public string? ConfirmPassword { get; set; }
	}
}
