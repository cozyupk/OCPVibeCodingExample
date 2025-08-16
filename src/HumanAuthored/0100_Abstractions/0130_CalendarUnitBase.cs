namespace HumanAuthored.Abstractions
{
    public abstract class CalendarUnitBase(
        long start = 0, long end = 0
    ) : IPrevUnit, INextUnit
    {
        protected IPrevUnit? PrevUnit { get; set; }

        protected INextUnit? NextUnit { get; set; }

        protected long Start { get; } = start;
        protected long End { get; private set; } = end;

        public abstract void Increment();

        public abstract string AsString();

        public void SetEnd(long end)
        {
            End = end;
        }
    }
}
