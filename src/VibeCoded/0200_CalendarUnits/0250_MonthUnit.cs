using VibeCoded.Abstractions;

namespace VibeCoded.CalendarUnits
{
    public class MonthUnit : CalendarUnitBase
    {
        private long _value;
        private readonly YearUnit _year;

        public MonthUnit(IPrevUnit prevUnit) : base(1, 12)
        {
            PrevUnit = prevUnit;
            _year = new YearUnit(this);
            NextUnit = _year;
            _value = Start;
            UpdateDaysEnd();
        }

        private void UpdateDaysEnd()
        {
            int year = _year.Value == 0 ? 1 : _year.Value;
            int month = (int)(_value == 0 ? 1 : _value);
            int days = DaysInMonth(year, month);
            PrevUnit?.SetEnd(days);
        }

        private static int DaysInMonth(int year, int month)
        {
            bool isLeap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return month switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => isLeap ? 29 : 28,
                _ => 30
            };
        }

        public override void Increment()
        {
            _value++;
            if (_value > End)
            {
                NextUnit?.Increment();
                _value = Start;
            }
            UpdateDaysEnd();
        }

        public override string AsString()
        {
            return NextUnit?.AsString() + $"{(NextUnit != null ? "-" : "")}{_value:D2}";
        }
    }
}
