namespace SchGenerator
{
    internal class GenerateSchedule
    {
        public List<DateTime> result = null;
        internal void Generate()
        {
            int NextMonth;
            var NextYear = DateTime.Now.Year;

            if (DateTime.Now.Month == 12)
            {
                NextMonth = 1;
                NextYear = DateTime.Now.Year + 1;
            }
            else
            {
                NextMonth = DateTime.Now.Month + 1;
            }

            var currentMonth = Days.GetDates(DateTime.Now.Year, DateTime.Now.Month);
            var nextMonth = Days.GetDates(NextYear, NextMonth);

            var actualMonth = currentMonth.Where(x => x >= DateTime.Now).ToList();
            nextMonth.ToList();
            result = actualMonth.Concat(nextMonth).ToList();
        }
    }
}
