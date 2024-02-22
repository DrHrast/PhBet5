using PhBet5.Models;

namespace PhBet5.Services
{
    public class UserBettingService
    {
        private readonly AppDbContext _context;

        public UserBettingService(AppDbContext context)
        {
            _context = context;
        }

        public void CreateBet(UserBettingModel bet)
        {
            _context.Betting.Add(bet);
            _context.SaveChanges();
        }

        public List<UserBettingModel> GetUserBettingDetails(int id)
        {
            return _context.Betting.Where(b => b.UserId == id).ToList();
        }

        public List<UserBettingModel> GetAll()
        {
            return _context.Betting.ToList();
        }

        public void UpdateBet(int id, UserBettingModel bet)
        {
            UserBettingModel user = _context.Betting.FirstOrDefault(bet => bet.UserId == id);

            if (user != null)
            {
                user.IsCalculated = bet.IsCalculated;
                user.IsWon = bet.IsWon;
                user.IsFinished = bet.IsFinished;

                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("404: User not found.");
            }
        }
    }
}
