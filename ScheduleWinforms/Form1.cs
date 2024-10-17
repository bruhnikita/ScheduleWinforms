using ScheduleWinforms;
using System.Windows.Forms;

namespace ScheduleWinforms
{
    public partial class MainForm : Form
    {
        private List<Event> events = new List<Event>();
        private System.Timers.Timer timer;

        public MainForm()
        {
            InitializeComponent();
            timer = new System.Timers.Timer(60000);
            timer.Elapsed += CheckForReminders;
            timer.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Пожалуйста, введите корректное название и время события.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newEvent = new Event
            {
                Title = txtTitle.Text,
                DateTime = dateTimePicker1.Value,
                ReminderTime = null,
                Reminded = false 
            };

            events.Add(newEvent);
            UpdateEventsList();
            ClearInputFields();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Event selectedEvent)
            {
                events.Remove(selectedEvent);
                UpdateEventsList();
            }
            else
            {
                MessageBox.Show("Выберите событие.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckForReminders(object sender, System.Timers.ElapsedEventArgs e)
        {
            var now = DateTime.Now;

            foreach (var evt in events.ToList())
            {
                if (evt.ReminderTime.HasValue && !evt.Reminded)
                {
                    if (now >= evt.ReminderTime)
                    {
                        MessageBox.Show($"Напоминание: {evt.Title} в {evt.DateTime}", "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        evt.Reminded = true; 
                        UpdateEventsList();
                    }
                }
            }
        }

        private void UpdateEventsList()
        {
            listBox1.Items.Clear();
            foreach (var evt in events)
            {
                listBox1.Items.Add(evt);
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnSetReminder_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Event selectedEvent)
            {
                int reminderMinutes = (int)numericUpDownReminder.Value;

                selectedEvent.ReminderTime = selectedEvent.DateTime.AddMinutes(-reminderMinutes);

                MessageBox.Show($"Напоминание для '{selectedEvent.Title}' установлено на {reminderMinutes} минут до события.", "Напоминание", MessageBoxButtons.OK);
                UpdateEventsList();
            }
            else
            {
                MessageBox.Show("Выберите событие для установки напоминания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
