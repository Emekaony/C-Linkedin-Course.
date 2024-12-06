using basics.audio;

namespace basics {
    public class Program {
        public static void Main(string[] args) {
            string filename = "emeka.mp3";
            AudioTranscriber.Elevate(filename, 1, 2);
        }
    }

}