using System.ComponentModel.DataAnnotations.Schema;

namespace SchGenerator.Models
{
    [Table("ActualSchedule")]
    public class ActualSchedule
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("event_info")]
        public string Event { get; set; } 

        [Column("event_date")]
        public string Date { get; set; }
    }
}
