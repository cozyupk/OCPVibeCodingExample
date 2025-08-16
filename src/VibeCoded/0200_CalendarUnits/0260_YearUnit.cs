using VibeCoded.Abstractions;

namespace VibeCoded.CalendarUnits
{
    public class YearUnit : CalendarUnitBase
    {
        private long _value;
        public YearUnit(IPrevUnit prevUnit) : base(1, 9999)
        {
            PrevUnit = prevUnit;
            _value = Start; // initialize to AD 0001
        }

        public int Value => (int)_value;

        public override void Increment()
        {
            _value++;
            if (_value > End)
            {
                _value = End; // clamp at 9999
            }
        }

        public override string AsString()
        {
            return $"{_value:D4}";
        }
    }
}
