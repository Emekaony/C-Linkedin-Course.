// using basics.exercises;
using basics.oop;

namespace basics {
    public class Basics() {

        public static void Main() {
            // List<string> words = ["Race car!", "Madam", "Madam, I'm Adam", "speak"];
            // foreach (string word in words) {
            //     Console.WriteLine(TextAlgorithms.IsPalindrome(word));
            // }
            Book b1 = new("War and Peace", "Leo Tolstoy", 800);
            Book b2 = new("Things fall apart", "Chinua Achebe", 464);

            // call methods on each book object
            b1.GetDescription();
            b2.GetDescription();
        }

    }
}