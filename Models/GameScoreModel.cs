using System.ComponentModel.DataAnnotations;

namespace PhBet5.Models
{
    public class GameScoreModel
    {
        [Key]public int Id { get; set; }
        public int BetsId { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
    }
}
