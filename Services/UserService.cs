using PhBet5.Models;

namespace PhBet5.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public void CreateUser(UserModel user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public UserModel GetUser(string username)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == username);
        }

        public UserModel GetUser(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public UserModel Login(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }

        public void UpdateUser(int id, UserModel user)
        {
            UserModel userModel = _context.Users.FirstOrDefault(user => user.Id == id);
            if (userModel != null)
            {
                userModel.Balance = user.Balance;

                _context.SaveChanges();
            }
        }
    }
}
