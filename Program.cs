namespace Program {
    public class Basics() {

        public static void Main(string[] args) {
            int[] numbers = [1, 2, 3];
            foreach (int number in numbers) {
                Console.WriteLine($"The number we're looking at is: {number}");
            }
            string messageToThePeople = "I will win";
            if (messageToThePeople.Length > 10) {
                Console.WriteLine("It is time!");
            } else {
                Console.WriteLine("It is still time my brother");
            }
        }

    }
}