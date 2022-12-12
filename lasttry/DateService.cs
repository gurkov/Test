using SchGenerator.Models;
using Microsoft.EntityFrameworkCore;


namespace SchGenerator
{
    public class DateService
    {
        public async Task SetStandartSheduleAsync()
        {
            using (var context = new ScheduleContext())
            {
                GenerateSchedule gen = new();
                gen.Generate();
                List<DateTime> Result = gen.result;
                await context.Database.ExecuteSqlRawAsync("TRUNCATE TABLE [ActualSchedule]");

                foreach (var value in Result)
                {
                    var author = new ActualSchedule
                    {
                        Event = value.GetStandartNote(),
                        Date = value.ToString("d"),
                    };

                    context.ActualSchedules.Add(author);
                    context.SaveChanges();
                }
            }
        }
    }
}
