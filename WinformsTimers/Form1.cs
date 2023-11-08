using System.Timers;

namespace WinformsTimers
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;
        private DateTime newYearDate = new DateTime(2024, 1, 1);
        private DateTime startTime;
        public Form1()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += HandleTimeEvent;
            timer.Enabled = true;
            startTime = DateTime.Now;
        }

        private void HandleTimeEvent(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeLeft = newYearDate - DateTime.Now;
            label1.Text = "До нового года осталось: " +
                $"{timeLeft.Days} дня., " +
                $"{timeLeft.Hours} ч., " +
                $"{timeLeft.Minutes} мин., " +
                $"{timeLeft.Seconds} с.";

            TimeSpan timeElapsed = DateTime.Now - startTime;
            Text = "Время с момента запуска: "
                + $"{(int)timeElapsed.TotalMilliseconds} мс";
        }
    }
}