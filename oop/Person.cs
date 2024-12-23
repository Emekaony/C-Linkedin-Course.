namespace basics.oop {
    public class Person(string firstName, string lastName, int age) {

        private string _firstname = firstName;
        protected string _lastname = lastName;
        private int _age = age;

        // declare a computed public property 
        public string FirstName {
            get {
                return _firstname;
            }
            set {
                _firstname = value;
            }
        }

        // second computed property (easier shorthand method)
        public string LastName {
            get => _lastname;
            set => _lastname = value;
        }

        public int Age {
            get => _age;
            set => _age = value;
        }

        // do not foegt that computed properties are not functions!
        public string Description {
            get => $"{FirstName} {LastName} is {Age} years old!";
        }

        public required string ISBN {
            get; set;
        }
    }
}