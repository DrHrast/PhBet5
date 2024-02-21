using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhBet5.Models
{
    public class UserBettingModel
    {
        [Key]public int Id { get; set; }
        public int UserId { get; set; }
        public int BetId { get; set; }
        public DateTime BetPlacedDate { get; set; } = DateTime.Now;
        public string BetName { get; set; } //Spoj sporta, tima 1, tima 2
        public DateTime GameDate { get; set; }
        public double BetAmount { get; set; }
        public bool Team1Selected { get; set; }
        public bool Team2Selected { get; set; }
        public bool IsFinished { get; set; }
        public bool IsWon { get; set; }
        public bool IsCalculated { get; set; } = false;
    }
}
