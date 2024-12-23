

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
            Balance += deposit;
        }

        public virtual void Withdraw(decimal amount) {
            Balance -= amount;
        }
    }

    public class CheckingAcct(string fname, string lname, decimal startingBalance = 0.0m) : BankAccount(fname, lname, startingBalance) {
        private const decimal OVERDRAFT_FEE = 35.0m;
        public override void Withdraw(decimal amount) {
            // charge a $35 overdraft fee.
            if (amount > Balance) {
                base.Withdraw(amount + OVERDRAFT_FEE);
            } else {
                base.Withdraw(amount);
            }

        }
    }

    public class SavingsAcct(string fname, string lname, decimal rate, decimal startingBalance = 0.0m) : BankAccount(fname, lname, startingBalance) {
        private const int WITHDRAW_LIMIT = 3;
        private const decimal WITHDRAWAL_FEE = 2.0m;
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

            if (amount > Balance) {
                Console.WriteLine("Attempt to withdraw past current Balance denied.");
            } else {
                base.Withdraw(amount + WITHDRAWAL_FEE);
                Console.WriteLine($"Current savings balance is: {Balance}");
                withdawalCount++;

                // charge fee for more than 3 withdrawals
                if (withdawalCount > WITHDRAW_LIMIT) {
                    base.Withdraw(WITHDRAWAL_FEE);
                }
            }
        }
    }

}
