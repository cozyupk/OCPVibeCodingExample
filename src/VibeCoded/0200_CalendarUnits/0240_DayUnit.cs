using VibeCoded.Abstractions;

namespace VibeCoded.CalendarUnits
{
    public class DayUnit : CalendarUnitBase
    {
        private long _value;
        public DayUnit(IPrevUnit prevUnit) : base(1, 31)
        {
            PrevUnit = prevUnit;
            NextUnit = new MonthUnit(this);
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
            return NextUnit?.AsString() + $"{(NextUnit != null ? "-" : "")}{_value:D2}";
        }
    }
}
