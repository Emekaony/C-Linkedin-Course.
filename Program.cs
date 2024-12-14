using basics.exercises;

namespace basics {
    public class Basics() {

        public static void Main() {
            List<string> words = ["Race car!", "Madam", "Madam, I'm Adam", "speak"];
            foreach (string word in words) {
                Console.WriteLine(TextAlgorithms.IsPalindrome(word));
            }
        }

    }
}