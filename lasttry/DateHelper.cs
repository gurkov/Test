namespace SchGenerator
{
    public static class DateHelper
    {
        internal static bool IsBeforeFirstSunday(this DateTime date)
        {
            var closestSunday = date.Next(DayOfWeek.Sunday);
            var week = closestSunday.GetWeekOfMonth();

            return week == 1;
        }
    }
}
