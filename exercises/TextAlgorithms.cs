namespace basics.exercises {

    public class TextAlgorithms {
        // ignores white space and punctuations
        public static bool IsPalindrome(string thestr) {
            if (thestr.Length <= 1) {
                return true;
            }
            bool verdict = true;
            int start = 0;
            int end = thestr.Length - 1;

            while (start < end) {
                // check if start is a punctuation is white-space
                char startCharacter = thestr[start];
                char endCharacter = thestr[end];
                // if the start character is white-space or a punctuation, ignore it & move forward
                if (char.IsPunctuation(startCharacter) || char.IsWhiteSpace(startCharacter)) {
                    start++;
                    continue;
                }

                // similarly, // if the end character is white-space or a punctuation, ignore it & move towards the left
                if (char.IsPunctuation(endCharacter) || char.IsWhiteSpace(endCharacter)) {
                    end--;
                    continue;
                }

                // perform case-independent comparison
                if (char.ToLower(startCharacter) != char.ToLower(endCharacter)) {
                    verdict = false;
                    break;
                } else {
                    start++;
                    end--;
                }
            }

            return verdict;
        }
    }
}