

// Write your answer here, and then test your code.
// Your job is to implement the findLargest() method.
namespace basics.oop {
    public class BankAccount(string fname, string lname, decimal startingBalance = 0.0m) {
        private readonly string _firstName = fname;
        private readonly string _lastName = lname;
        private decimal _balance = startingBalance;

        public decimal Balance {
            get => _balance;
            set => _balance = value;
        }

        public string FirstName {
            get => _firstName;
        }

        public string LastName {
            get => _lastName;
        }

        public string AccountOwner {
            get => $"{FirstName} {LastName}";
        }

        public virtual void Deposit(decimal deposit) {
            this.Balance += deposit;
        }

        public virtual void Withdraw(decimal amount) {
            this.Balance -= amount;
        }
    }

    public class CheckingAcct(string fname, string lname, decimal startingBalance = 0.0m) : BankAccount(fname, lname, startingBalance) {
        public override void Withdraw(decimal amount) {
            // charge a $35 overdraft fee.
            if (amount > this.Balance) {
                base.Withdraw(amount + 35.0m);
            } else {
                base.Withdraw(amount);
            }

        }
    }

    public class SavingsAcct(string fname, string lname, decimal rate, decimal startingBalance = 0.0m) : BankAccount(fname, lname, startingBalance) {
        private decimal _interestRate = rate;
        private int withdawalCount = 0;

        public decimal InterestRate {
            get => _interestRate;
            set => _interestRate = value;
        }

        public void ApplyInterest() {
            // apply the interest rate
            Balance += InterestRate * Balance;
        }

        public override void Withdraw(decimal amount) {
            // check to see if we exceed the current balance
            if (amount < this.Balance) {
                if (withdawalCount >= 3) {
                    base.Withdraw(amount + 2.0m);
                    Console.WriteLine($"Current savings balance is: {this.Balance}");
                    withdawalCount++;
                } else {
                    base.Withdraw(amount);
                    Console.WriteLine($"Current savings balance is: {this.Balance}");
                    withdawalCount++;
                }
            }
        }
    }

}
