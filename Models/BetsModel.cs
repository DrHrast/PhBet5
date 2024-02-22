using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhBet5.Models
{
    public class BetsModel
    {
        [Key] public int BetId { get; set; }
        public string BetSport { get; set; }
        public string BetTeam1 { get; set; }
        public string BetTeam2 { get; set; }
        public double BetRatio { get; set; }
        public DateTime BetDate { get; set; }
        public bool Team1Selected { get; set; }
        public bool Team2Selected { get; set; } 
        public double BetAmount { get; set; } 




        [NotMapped]
        public string BetDateAsString => BetDate.ToString("dd.MM.yyyy HH:mm");

        [NotMapped]
        public string TimeRemaining
        {
            get
            {
                TimeSpan timeRemaining = BetDate - DateTime.Now;
                if (timeRemaining.Days > 0)
                {
                    return $"{timeRemaining.Days} days, {timeRemaining.Hours}:{timeRemaining.Minutes}";
                }
                return $"{timeRemaining.Hours}:{timeRemaining.Minutes}";
            }
        }
    }
}