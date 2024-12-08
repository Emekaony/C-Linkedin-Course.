namespace basics.audio {
    public class AudioTranscriber {
        public static void Elevate(string filename, int start, int end) {
            Console.Write("Please enter ur first name: ");
            string name = Console.ReadLine() ?? "";
            if (string.IsNullOrEmpty(name)) {
                Console.WriteLine("User must enter valid text please!");
            }
        }
    }
}