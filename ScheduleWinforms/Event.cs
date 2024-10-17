using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleWinforms
{
    public class Event
    {
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime? ReminderTime { get; set; }
        public bool Reminded { get; set; }

        public override string ToString()
        {
            return $"{Title} - {DateTime} (Напоминание: {ReminderTime?.ToString() ?? "не установлено"})";
        }
    }
}
