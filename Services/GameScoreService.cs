using Microsoft.EntityFrameworkCore;
using PhBet5.Models;

namespace PhBet5.Services
{
    public class GameScoreService
    {
        private readonly AppDbContext _context;

        public GameScoreService(AppDbContext context)
        {
            _context = context;
        }

        public GameScoreService() { }

        public bool GetTeamOneWon(int id)
        {
            //GameScoreModel user = _context.GameScore.FirstOrDefault(bet => bet.UserId == id);

            GameScoreModel model = _context.GameScore.FirstOrDefault(x => x.BetsId == id);
            return model.Team1Score > model.Team2Score ? true : false;
        }

        public bool GetTeamTwoWon(int id)
        {
            //GameScoreModel user = _context.GameScore.FirstOrDefault(bet => bet.UserId == id);

            GameScoreModel model = _context.GameScore.FirstOrDefault(x => x.BetsId == id);
            return model.Team2Score > model.Team1Score ? true : false;
        }
    }
}
