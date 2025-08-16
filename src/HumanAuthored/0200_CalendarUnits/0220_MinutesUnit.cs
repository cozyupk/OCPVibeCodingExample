using HumanAuthored.Abstractions;

namespace HumanAuthored.CalendarUnits
{
    public class MinuteUnit : CalendarUnitBase
    {
        private long _value;
        public MinuteUnit(IPrevUnit prevUnit) : base(0, 59)
        {
            PrevUnit = prevUnit;
            // NextUnit = new Hour();
        }
        public override void Increment()
        {
            _value++;
            if (_value > End)
            {
                _value = Start;
            }
        }

        public override string AsString()
        {
            return NextUnit?.AsString() + $"{(NextUnit != null ? ":" : "")}{_value:D2}";
        }
    }
}
