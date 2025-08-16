namespace VibeCoded
{
    internal class  Program
    {
        private static Random RandomToAdd { get; } = new();

        public static void Main(string[] _)
        {
            // Create a new instance of SecondsUnit
            var secondsUnit = new CalendarUnits.SecondsUnit();
            // Increment the seconds unit a few times
            long elapsedSeconds = 0;
            for (int i = 0; i < 1000; i++)
            {
                int j = 0;
                for (; j < RandomToAdd.Next(0, Int32.MaxValue); j++)
                {
                    secondsUnit.Increment();
                }
                elapsedSeconds += j;
                Console.WriteLine($"After {j:N0} seconds: {secondsUnit.AsString()}");
                secondsUnit.Increment();
            }
            // Output the final state
            Console.WriteLine("Final time: " + secondsUnit.AsString());
        }
    }
}
