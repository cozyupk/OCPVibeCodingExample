using HumanAuthored.Abstractions;

namespace HumanAuthored.CalendarUnits
{
    public class SecondsUnit : CalendarUnitBase
    {
        private long _value;
        public SecondsUnit() : base(0, 59)
        {
            NextUnit = new MinuteUnit(this);
        }
        public override void Increment()
        {
            _value++;
            if (_value > End)
            {
                NextUnit?.Increment();
                _value = Start;
            }
        }

        public override string AsString()
        {
            return NextUnit?.AsString() + $"{(NextUnit != null ? ":" : "")}{_value:D2}";
        }
    }
}
