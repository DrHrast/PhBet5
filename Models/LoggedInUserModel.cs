using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PhBet5.Models
{
    public class LoggedInUserModel : UserModel
    {
        private double _balance;

        public new double Balance
        {
            get => _balance;
            set
            {
                _balance = value;
                NotifyPropertyChanged();
            }
        }


        public event EventHandler propertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void Reset()
        {
            Id = 0;
            UserName = "";
            Password = "";
            Email = "";
        }
    }
}
