using System.Globalization;

namespace SchGenerator
{
    static class WeekOfMonth_Year
    {
        static GregorianCalendar _gc = new GregorianCalendar();
        internal static int GetWeekOfMonth(this DateTime time)
        {
            DateTime first = new DateTime(time.Year, time.Month, 1);
            return DateTime.Today.Month == 12 ? time.GetWeekOfYear() - first.GetWeekOfYear() + 1
                                              : time.GetWeekOfYear() - first.GetWeekOfYear();
        }

        static int GetWeekOfYear(this DateTime time)
        {
            return _gc.GetWeekOfYear(time, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
        }
    }
}