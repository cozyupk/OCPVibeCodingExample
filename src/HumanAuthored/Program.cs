namespace HumanAuthored
{
    internal class Program
    {
        private static Random RandomToAdd { get; } = new();

        public static void Main(string[] _)
        {
            var secondsUnit = new CalendarUnits.SecondsUnit();

            for (int i = 0; i < 1000; i++)
            {
                long elapsedSeconds = 0;
                int j = 0;
                int add = RandomToAdd.Next(0, 100_000);
                for (; j < add; j++)
                {
                    secondsUnit.Increment();
                }

                elapsedSeconds += j;
                Console.WriteLine($"After {elapsedSeconds:N0} seconds: {secondsUnit.AsString()}");
            }

            Console.WriteLine("Final time: " + secondsUnit.AsString());
        }
    }
}
