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

        public UserBettingModel GetUserBettingDetails(int id)
        {
            return _context.Betting.FirstOrDefault(b => b.Id == id);
        }

        public List<UserBettingModel> GetAll()
        {
            return _context.Betting.ToList();
        }
    }
}
