using System.Collections.Concurrent;
using basics.oop;

namespace basics {
    public class Basics() {

        public static void Main() {
            Person p1 = new("Emeka", "Ony", 22) {
                // this is where you set those required fields
                ISBN = "ah"
            };
        }
    }
}