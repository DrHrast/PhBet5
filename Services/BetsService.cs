using PhBet5.Models;
using System.Runtime.InteropServices;

namespace PhBet5.Services
{
    public class BetsService
    {
        private readonly AppDbContext _context;

        public BetsService(AppDbContext context)
        {
            _context = context;
        }

        public List<BetsModel> GetAll()
        {
            return _context.Bets.ToList();
        }

        public List<BetsModel> GetBySport(string sport)
        {
            return _context.Bets.Where(u => u.BetSport == sport).ToList();
        }
    }
}
