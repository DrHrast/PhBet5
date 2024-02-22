using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhBet5.Models
{
    public class UserBettingModel
    {
        [Key] public int Id { get; set; }
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

        [NotMapped]
        public string GameDateAsString => GameDate.ToString("dd.MM.yyyy HH:mm");
        [NotMapped]
        public string BetPlaceDateAsString => BetPlacedDate.ToString("dd.MM.yyyy HH:mm");
        [NotMapped]
        public string BetState => IsWon ? "Win" : "Lose";
        [NotMapped]
        public string FinishedState
        {
            get
            {
                if (IsFinished)
                {

                    TimeSpan timeFinished = DateTime.Now - GameDate;
                    if (timeFinished.Days >= 1)
                    {
                        return $"Game finished {timeFinished.Days} days ago";
                    }
                    else if (timeFinished.Days < 1 && timeFinished.Days > 0)
                    {
                        return $"Game finished {timeFinished.Hours} hours and {timeFinished.Minutes} minutes ago";
                    }
                }
                else
                {
                    return "In progress";
                }
                return "";
            }
        }
    }
}
