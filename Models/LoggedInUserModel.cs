namespace PhBet5.Models
{
	public class LoggedInUserModel
	{
		public int Id { get; set; }
		public UserBettingModel BettingDetails { get; set; }
		public UserModel User { get; set; }

		public void Reset()
		{
			Id = 0;
			BettingDetails = null;
		}
	}
}
