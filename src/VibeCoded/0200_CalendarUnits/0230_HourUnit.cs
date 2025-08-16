using VibeCoded.Abstractions;

namespace VibeCoded.CalendarUnits
{
    public class HourUnit : CalendarUnitBase
    {
        private long _value;
        public HourUnit(IPrevUnit prevUnit) : base(0, 23)
        {
            PrevUnit = prevUnit;
            NextUnit = new DayUnit(this);
            _value = Start;
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
            return NextUnit?.AsString() + $"{(NextUnit != null ? " " : "")}{_value:D2}";
        }
    }
}
