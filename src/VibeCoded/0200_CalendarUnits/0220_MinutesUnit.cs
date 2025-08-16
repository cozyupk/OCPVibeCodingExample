using VibeCoded.Abstractions;

namespace VibeCoded.CalendarUnits
{
    public class MinuteUnit : CalendarUnitBase
    {
        private long _value;
        public MinuteUnit(IPrevUnit prevUnit) : base(0, 59)
        {
            PrevUnit = prevUnit;
            NextUnit = new HourUnit(this);
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
